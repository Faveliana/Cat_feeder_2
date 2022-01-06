using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp1.Data.Model;
using static WindowsFormsApp1.Data.Repository;


namespace WindowsFormsApp1.Data
{
    public static class ReaderExtensions
    {
        internal static int GetReturn(this SqlCommand command) =>
            (int)command.Parameters[ReturnValue].Value;

        internal static T GetFieldValue<T>(this SqlDataReader reader, string col) => (T)reader[Unwrap(col)];

        internal static UserBase GetUser(this SqlDataReader reader)
        {
            if (!reader.Read()) throw new ArgumentException("Нет такого пользователя");

            return new UserBase(reader.GetFieldValue<int>(Id),
                reader.GetFieldValue<string>(Login),
                reader.GetFieldValue<string>(Password));
        }

        internal static IEnumerable<Schedule> GetAllSchedule(this SqlDataReader reader)
        {
            var list = new List<Schedule>();
            while (reader.Read())
                list.Add(new Schedule(reader.GetFieldValue<int>(Id),
                    reader.GetFieldValue<TimeSpan>(Time)));
            return list;
        }

        internal static FeederBase GetFeeder(this SqlDataReader reader)
        {
            if (!reader.Read()) throw new ArgumentException("Нет такой кормушки");
            return new FeederBase(reader.GetFieldValue<int>(Id),
                reader.GetFieldValue<int>(Status),
                reader.GetFieldValue<FeederType>(TypeId));
        }
    }
}