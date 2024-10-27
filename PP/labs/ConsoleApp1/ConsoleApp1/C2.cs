using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{ 
    class C2 : C1, I1
    {
        public int Id {get;set;}
        public void Method()
        {
            Console.WriteLine("Hello world");
        }
        public event EventHandler Event;
        public int this[int index]
        {
            get { return index; }
            set { index = value; }
        }
        public void PrintI()
        {
            this.PrintInfos();
        }
    }
}