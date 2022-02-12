using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.User
{
    public class AccountCreate
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }

        public AccountCreate()
        {
        }

        public AccountCreate(string name, string email, string date)
        {
            Name = name;
            Email = email;
            Date = date;
        }
        public override string ToString()
        {
            return Name + ", " + Email + ", " + Date;
        }
    }
}
