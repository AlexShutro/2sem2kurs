using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1;

class C3 : C2
{
    public int Id { get; set; }
    public void Method()
    {
        Console.WriteLine("Method");
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

class C4 : C3
{
    public int Id{get; set;}
    public void Method()
    {
        Console.WriteLine("Method");
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