using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace met
{
    public class ValidationService
    {
        public bool ValidationLogin(string login)
        {
            if(login!=null && login.Length > 4)
            {
                return true;
            }
            return false;
        }
        public bool ValidationPassword(string password)
        {
            if (password.Length > 6 && !password.Contains(" "))
            {
                return true;
            }
            return false;
        }
        public bool ValidationEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            return false;
        }
        public bool ValidationAge(string age)
        {
            if ( age!=null && age.All(char.IsDigit) ) 
            {
                return true;
            }
            return false;
        }
    }
}
