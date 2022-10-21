using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Administrator
    {
        public MainLibrary MainLibrary { get; set; }
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPasswrd { get; set; }
        public string BUsers { get; set; }

        public Administrator(int adminId, string adminName, string adminPasswrd)
        {
            AdminId = adminId;
            AdminName = adminName;
            AdminPasswrd = adminPasswrd;
        }

        public void AddBook(Book a)
        {
            MainLibrary.AddBook(a);
        }
        public void DelBook(Book a)
        {
            MainLibrary.DelBook(a);
        }
        public void AddUser(User a)
        {
            MainLibrary.AddUser(a);
        }
        public void BlockUser(User a)
        {
            MainLibrary.BlockUser(a);
        }

        public bool UserIsBlocked(User a)
        {
            foreach (var item in BlockedUsers)
            {
                if (item == a)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }
    }
}