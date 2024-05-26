using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsMVVM.Models
{
    public class User
    {
        public User()
        {
        }

        public User(string? name, string? email)
        {
            Name = name;
            Email = email;
        }

        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
