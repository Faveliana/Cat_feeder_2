namespace WindowsFormsApp1.Data.Model
{
    public class UserBase
    {
        public UserBase(int id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
        }

        public UserBase(UserBase user)
        {
            Id = user.Id;
            Login = user.Login;
            Password = user.Password;
        }

        public int Id { get; }
        public string Login { get; }
        public string Password { get; }

    }
}