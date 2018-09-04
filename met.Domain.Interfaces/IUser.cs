using System;
using System.Collections.Generic;
using System.Text;
using met.Domain.Core;

namespace met.Domain.Interfaces
{
    public interface IUser : IDisposable
    {
        void Create(User user);
        void Update(User user);
        void Delete(string id);
        List<User> GetUsers();
    }
}
