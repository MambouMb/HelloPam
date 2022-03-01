

using HelloPam.BO;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace HelloPam.DAL
{
    public class UserDAO
    {
        private readonly Sql sql;
        public UserDAO()
        {
            sql = new Sql("HelloPam");
        }
        public void Add(User user)
        {
            sql.Execute("sp_user_Insert",
                GetParameters(user),
                true
                );
        }
        public User Get(int id)
        {
            var reader = sql.Read
                (
                    "sp_user_Select",
                    GetParameters(new User { Id = id }),
                    true
                );
            while (reader.Read())
                return GetObject(reader);
            reader.Close();

            return null;
        }
        public User Login(string username, string password)
        {
            var reader = sql.Read
                (
                    "sp_user_Login",
                    GetParameters(new User { Username = username, Password = password }),
                    true
                );
            while (reader.Read())
                return GetObject(reader);
            reader.Close();

            return null;
        }

        public void Set(User user)
        {
            sql.Execute("sp_user_Update",
                GetParameters(user),
                true
                );
        }
        public void Delete(int id)
        {
            sql.Execute("sp_user_Delete",
                GetParameters(new User { Id = id}),
                true
                );
        }
        public IEnumerable<User> Find(User user = null)
        {
            var reader = sql.Read
                (
                    "Sp_user_Select",
                    GetParameters(user),
                    true
                );
            var users = new List<User>();
            while (reader.Read())
                users.Add(GetObject(reader));
            reader.Close();

            return users;
        }
        private User GetObject(DbDataReader reader)
        {
            return new User
                (
                    reader ["Id"] == DBNull.Value ? 0: int.Parse(reader["Id"].ToString()),
                    reader["Username"] == DBNull.Value ? null: reader["Username"].ToString(),
                    reader["Password"] == DBNull.Value ? null : reader["Password"].ToString(),
                    reader["Fullname"] == DBNull.Value ? null : reader["Fullname"].ToString(),
                    reader["Profile"] == DBNull.Value ? User.ProfileOptions.VIsitor : (User.ProfileOptions)int.Parse(reader["Profile"].ToString()),
                    reader["Statut"] == DBNull.Value ? false : bool.Parse(reader["Statut"].ToString()),
                    reader["Picture"] == DBNull.Value ? null : (byte[])reader["Picture"],
                    reader["CreatedAt"] == DBNull.Value ? null : (DateTime?)DateTime.Parse(reader["CreatedAt"].ToString())
                );
        }
        private IEnumerable<Sql.Parameter>  GetParameters(User user)
        {
            return new Sql.Parameter[]
            {
                new Sql.Parameter("@Id", System.Data.DbType.Int32, (user == null || user.Id == 0? (object)DBNull.Value : user.Id)),
                new Sql.Parameter("@Username", System.Data.DbType.String, (user == null || string.IsNullOrEmpty(user.Username) ? (object)DBNull.Value : user.Username)),
                new Sql.Parameter("@Password", System.Data.DbType.String, (user == null || string.IsNullOrEmpty(user.Password) ? (object)DBNull.Value : user.Password)),
                new Sql.Parameter("@Fullname", System.Data.DbType.String, (user == null || string.IsNullOrEmpty(user.Fullname) ? (object)DBNull.Value : user.Fullname)),
                new Sql.Parameter("@Profile", System.Data.DbType.Int32, (user == null || user.Profile == null? (object)DBNull.Value : (int)user.Profile)),
                new Sql.Parameter("@Statut", System.Data.DbType.Boolean, (user == null || user.Statut == null ? (object)DBNull.Value : user.Statut)),
                new Sql.Parameter("@Picture", System.Data.DbType.Binary, (user == null || user.Picture == null ? (object)DBNull.Value : user.Picture)),
                new Sql.Parameter("@CreatedAt", System.Data.DbType.DateTime, (user == null || user.Picture == null ? (object)DBNull.Value : user.CreatedAt)),
            };
        }
    }
}
