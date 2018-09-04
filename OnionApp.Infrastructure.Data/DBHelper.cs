using System;
using System.Collections.Generic;
using System.Text;
using met.Domain.Core;
using Npgsql;

namespace OnionApp.Infrastructure.Data
{
    public class DBHelper
    {
        private DBHelper() { }
        private static DBHelper instance = null;
        public static DBHelper getInstance()
        {
            if (instance == null)
            {
                instance = new DBHelper();
            }
            return instance;
        }
        private NpgsqlConnection conn;
        public void Connection()
        {
            string connstring = String.Format("Server=127.0.0.1;Port=5432 ;" +
            "User Id=postgres;Password=root;Database=application;");
             conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
            }
            catch
            {
                conn.Close();
            }
        }
        public List<User> GetUsers()
        {
            NpgsqlCommand cmd = new NpgsqlCommand(@"Select id, login, password, email, age;", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            List<User> users = new List<User>();
            while (dr.Read())
            {
                User user = new User();
                user.ID =(string) dr[0];
                user.Login = (string)dr[1];
                user.Password = (string)dr[2];
                user.Email = (string)dr[3];
                user.Age = (int)dr[4];
                users.Add(user);
            }
            return users;
        }
        public void AddUser(User user)
        {
            string add = @"INSERT INTO u(login,password,email,age,numberphone) VALUES("+user.Login+","+user.Password+
                ","+user.Email+","+user.Age+")";
            NpgsqlCommand cmdW = new NpgsqlCommand(add, conn);
            cmdW.ExecuteNonQuery();
        }
        
           
    }
}
