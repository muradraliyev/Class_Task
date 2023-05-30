using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask2
{
    internal class User
    {
        private string userName;
        private string password;


        public User(string name)
        {
            Username = name;
        }

        public string Username
        {

            get => userName;
            set
            {

                if (value.Length >= 8)
                {
                    userName = value;
                }
                else 
                { 
                    Console.WriteLine("Duzgun daxil edin! 8 simvoldan cox olmalidir");
                }

            }

        }
        public string Password
        {

            get => password;
            set
            {

                if (value.Length>=8 && value.Any(char.IsDigit) && !(value.ToUpper().Equals(value)) && !(value.ToLower().Equals(value)))
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Sifrenin uzunlugu minimum 8 olmalidir ve icinde en az 1 boyuk herf,1 kicik herf ve 1 reqem olmalidir.");
                }

            }

        }
    }
}
