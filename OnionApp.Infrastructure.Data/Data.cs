using System;
using met.Domain.Interfaces;
using met.Domain.Core;
using System.Collections.Generic;

namespace OnionApp.Infrastructure.Data
{
    public class Data : IUser
    {
        private UserContext userContext = UserContext.getInstance();
        public void Create(User user)
        {
            DBHelper dBHelper = DBHelper.getInstance();
            dBHelper.AddUser(user);
            userContext.Users.Add(user);
        }

        public void Delete(string id)
        {
            for(int i =0; i<userContext.Users.Count; i++)
            {
                if(userContext.Users[i].ID==id)
                {
                    userContext.Users.Remove(userContext.Users[i]);
                    break;
                }
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
           return userContext.Users;
        }

        public void Update(User user)
        {
            for (int i=0;i<userContext.Users.Count;i++)
            {
                if(user.ID==userContext.Users[i].ID)
                {
                    userContext.Users[i] = user;
                }
            }
        }
    }
}
