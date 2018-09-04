using met.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;


namespace OnionApp.Infrastructure.Data
{
    public class UserContext
    {
        public  List<User> Users;
        private UserContext()
        {
            DBHelper dBHelper = DBHelper.getInstance();
            Users = new List<User>();
            Users = dBHelper.GetUsers();
        }
        private static UserContext instance = null;
        public static UserContext getInstance()
        {
            if (instance == null)
            {
                instance = new UserContext();
            }
            return instance;
        }
    }
}
