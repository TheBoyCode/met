using System;

namespace met.Domain.Core
{
    public class User
    {
        public string ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
