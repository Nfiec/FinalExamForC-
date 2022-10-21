using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class User
    {
        int id = 0;
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public MainLibrary library { get; set; }

        public User(string username, string pass)
        {
            Id = id++;
            UserName = username;
            Password = pass;
        }

        public void EditUser(string username, string pass)
        {
            UserName = username;
            Password = pass;
        }

        public void EditPassword(string pass)
        {
            Password = pass;
        }

        public void EditUser()
        {
            Console.WriteLine("User Name: ");
            UserName = Console.ReadLine();

            Console.WriteLine("User Password: ");
            Password = Console.ReadLine();
        }
        public Book FindBook(string a)
        {
            foreach (var item in library.Books)
            {
                if (item.BookName == a)
                {
                    return item;
                }
                else return null;
            }
            return null;
        }

    }
}
