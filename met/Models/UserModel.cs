using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace met.Models
{
    public class UserModel
    {
        public string ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public List<QuestionModel> Questions { get; set; }
    }
}
