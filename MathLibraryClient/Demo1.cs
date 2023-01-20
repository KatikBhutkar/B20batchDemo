public class X : P
{
    void PrintX()
    { 
        PrintP12(); 
        P p1 = new P();
        //p1.PrintP12();
        base.PrintP12();
    }


    void PrintR()
    {
        P y1 = new P();
        y1.Print12();
    }
}
