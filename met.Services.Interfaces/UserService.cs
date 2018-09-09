using met.Domain.Core;
using OnionApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace met.Services.Interfaces
{
    public class UserService
    {
        public void Add(User user)
        {
            DBHelper db = DBHelper.getInstance();
            db.AddUser(user);
        }
    }
}
