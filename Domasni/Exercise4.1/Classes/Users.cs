using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise4._1.Classes;

namespace Exercise4._1.Classes
{
    class Users
    {
        Users[] arrUsers = new Users[]
           {
            new Users("tomas","samsung",2605),
            new Users("stefan","pasle",15),
            new Users("dimitar","jovanov",32)
           };

        public string username;
        public string password;
        public int id;

        
        public Users(string user, string pass, int ID)
            {
                username = user;
                password = pass;
                id = ID;
            }

            // LOGIN USER 

            public static void Login()
            {
            var arrUsers = new Users[]
            {
            new Users("tomas","samsung",2605),
            new Users("stefan","pasle",15),
            new Users("dimitar","jovanov",32)
            };
            bool successfull = false;

            Console.WriteLine("Write your username:");
            var username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            var password = Console.ReadLine();
            string name = username.Trim();
            string name2 = password.Trim();
            foreach (Users user in arrUsers)
            {
                if (name == user.username && name2 == user.password)
                {
                    Console.WriteLine("You have successfully logged in !!!");
                    Console.ReadLine();
                    successfull = true;
                    break;
                }
            }
            if (!successfull)
            {
                Console.WriteLine("Your username or password is incorect, try again !!!");
            }
        }
        // REGISTER USER
        public void Register()
        {
           

            Console.WriteLine("Enter your username:");
            var username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            var password = Console.ReadLine();
            Console.WriteLine("Enter your id:");
            int id = int.Parse(Console.ReadLine());
            Array.Resize(ref arrUsers, arrUsers.Length + 1);
            arrUsers[arrUsers.Length - 1] = new Users(username.Trim(), password.Trim(), id);
        }
    }
}
