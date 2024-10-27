namespace Lab_1;

class Program
{
    private static void Main()
    {

        #region EX1
		
        C1 c1 = new C1();
        c1.Name = "Alexander";
        c1.PrintInfo();
		

        C1 c2 = new C1(1, "Alexander", "Shutro");
        c2.PrintInfo();

        C1 c3 = new C1(c2);
        c3.PrintInfo();
        #endregion

        #region EX4
        
        C2 c4 = new C2();
        c4.Name = "Alexander";
        c4.PrintInfo();

        c4.PrintI();


        #endregion
        #region EX5
       
        C4 c5 = new C4();
        c5.Name = "Alexander";
        c5.PrintI();

        #endregion
		


    }
}