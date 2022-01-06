using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WindowsFormsApp1.Data.Model;
using static System.Data.SqlDbType;


namespace WindowsFormsApp1.Data
{
    public static class Repository
    {
        private const int InvalidInt = -1;

        internal const string Id = "[id]";
        internal const string Login = "[login]";
        internal const string Password = "[password]";
        internal const string Time = "[time]";
        internal const string Status = "[status]";
        internal const string TypeId = "[type_id]";

        private const string LoginVar = "@login";
        private const string PasswordVar = "@password";

        private const string SelectUserProc = "SP_SelectUser";
        private const string SelectFeederProc = "SP_SelectFeeder";
        private const string SelectFeederScheduleProc = "SP_SelectFeederSchedule";
        private const string SelectUserFeederProc = "SP_SelectUserFeeder";

        private const string AuthorizeProc = "SP_Authorize";
        internal const string ReturnValue = "@RETURN_VALUE";
        private const string IdVar = "@id";

        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DataBaseCat;Integrated Security=True";
        private static readonly SqlConnection _connection = new SqlConnection(ConnectionString);

        private static SqlConnection Connection
        {
            get
            {
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();
                return _connection;
            }
        }
        internal static string Unwrap(string s) => s.Replace("[", "").Replace("]", "");

        internal static SqlParameter IdParameter(int id) =>
            new SqlParameter { ParameterName = IdVar, SqlDbType = Int, Value = id };

        private static SqlCommand Procedure(string name) =>
            new SqlCommand(name, Connection) { CommandType = CommandType.StoredProcedure };

        private static SqlCommand ProcedureReturn(string name)
        {
            var cmd = Procedure(name);
            cmd.Parameters.Add(new SqlParameter(ReturnValue, Int));
            cmd.Parameters[ReturnValue].Direction = ParameterDirection.ReturnValue;
            return cmd;
        }

        public static int Authorize(string login, string password)
        {
            using (var command = ProcedureReturn(AuthorizeProc))
            {
                command.Parameters.AddRange(new[]
                {
                    new SqlParameter {ParameterName = LoginVar,SqlDbType = NVarChar,Value = login},
                    new SqlParameter {ParameterName = PasswordVar,SqlDbType = NVarChar,Value = password}
                });
                command.ExecuteScalar();
                return command.GetReturn();
            }
        }

        public static User GetUser(string login, string password)
        {
            var id = Authorize(login, password);
            if (id == InvalidInt) throw new ArgumentException("Нет такого пользователя");
            return GetUser(id);
        }

        private static User GetUser(int id)
        {
            UserBase userBase;
            var idList = new List<int>();
            using (var command = Procedure(SelectUserProc))
            {
                command.Parameters.Add(IdParameter(id));
                using (var reader = command.ExecuteReader())
                    userBase = reader.GetUser();
            }
            using (var command = Procedure(SelectUserFeederProc))
            {
                command.Parameters.Add(IdParameter(id));
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                        idList.Add(reader.GetFieldValue<int>(Id));
            }

            var feederList = idList.Select(GetFeeder).ToList();
            return new User(userBase, feederList);
        }

        private static Feeder GetFeeder(int id)
        {
            FeederBase feeder;
            using (var command = Procedure(SelectFeederProc))
            {
                command.Parameters.Add(IdParameter(id));
                using (var reader = command.ExecuteReader())
                    feeder = reader.GetFeeder();
            }

            using (var command = Procedure(SelectFeederScheduleProc))
            {
                command.Parameters.Add(IdParameter(id));
                using (var reader = command.ExecuteReader())
                    return new Feeder(feeder, reader.GetAllSchedule());
            }
        }
    }
}