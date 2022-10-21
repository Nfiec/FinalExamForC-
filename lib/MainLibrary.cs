using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MainLibrary
    {
        public List<Book> Books = new List<Book>();
        public List<User> Users = new List<User>();
        public List<User> BlockedUsers = new List<User>();
        public void AddBook(Book a)
        {
            Books.Add(a);
        }
        public void DelBook(Book a)
        {
            Books.Remove(a);
        }
        public void AddUser(User a)
        {
            Users.Add(a);
        }
        public void BlockUser(User a)
        {
            BlockedUsers.Add(a);
        }
    }
}
