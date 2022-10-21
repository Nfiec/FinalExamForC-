using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FeadBack
    {
        public User Author { get; set; }
        public DateTime Date { get; set; }
        public string comment { get; set; }

        public FeadBack(User author, string comment)
        {
            this.comment = comment;
            Author = author;
            Date = DateTime.Now;
        }
    }
}
