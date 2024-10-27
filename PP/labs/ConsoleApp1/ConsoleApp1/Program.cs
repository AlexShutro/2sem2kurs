using System.Runtime.CompilerServices;

namespace lab_1;
class Program
{
    private static void Main()
    {
        C1 c1 = new C1();
        c1.Name = "George";
        c1.PrintInfo();

        C1 c2 = new C1(1,"George","Petrov");
        c2.PrintInfo();

        C1 c3 = new C1(c2);
        c3.PrintInfo();

        C2 c4 = new C2();
        c4.Name = "George";
        c4.PrintInfo();
        c4.PrintI();

        C4 c5 = new C4();
        c5.Name = "George";
        c5.PrintInfo();
    }
}