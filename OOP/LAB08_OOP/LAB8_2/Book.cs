using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB8_2
{
    public class Book
    {
        public Title Title { get; set; }

        public string Publisher { get; set; }
        public int? Size { get; set; }
        public DateTime OpenDate { get; set; }
        public string Format { get; set; }

        public Book() { 
            Title = new Title();
        }    
    }
}
