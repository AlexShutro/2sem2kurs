using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class C1
    {
        private const string MODEL = "BMW";
        public const double NUM = 2.34;
        protected const string TYPE = "gasoline";


        private int _id;
        public string _name;
        protected string _surname;
    
        private int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        protected string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public C1()
        {
            Id = 0;
            Name = "George";
            Surname = "Petrov";
        }
        public C1 (int id,string name,string surname)
        {
            Id = id;
            Name = name;    
            Surname = surname;
        }
        public C1(C1 c1)
        {
            Id = c1.Id;
            Name = c1.Name;
            Surname = c1.Surname;
        }
        private void Print()
        {
            Console.WriteLine("Id: {0},Name: {1}, Surname: {2}", Id, Name, Surname);

        }
        public void PrintInfo()
        {
            Console.WriteLine("MODEL: {0},NUM: {1},TYPE: {2}", MODEL, NUM, TYPE);
        }
        protected void PrintInfos()
        {
            Console.WriteLine("Test");
        }
    }

}