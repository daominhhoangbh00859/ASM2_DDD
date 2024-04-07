using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_2_DDD
{
    public class User
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public string Address { get; set; }
        public int Gender { get; set; }
        public char Role { get; set; }


        public User(int id, string name, string email, string password, string address, int gender, char role)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Address = address;
            Gender = gender;
            Role = role;
        }

        public User() { }
    }

}
