using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Book
    {
        public int TypeBook { get; set; }
        public int IdBook { get; set; }
        public string BookName { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishYear { get; set; }
        public List<FeadBack> feadBack = new List<FeadBack>();

        public void AddFeedBack(User a, string b)
        {
            feadBack.Add(new FeadBack(a, b));
        }
    }
}