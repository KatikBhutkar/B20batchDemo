 class P
{
   protected internal  void PrintP12()
    {
        Console.WriteLine("P");
    }
}


 class Q : P
{
     internal void  PrintP123()
    {
        Console.WriteLine("Q");
        base.PrintP12();
        //P p1 = new P();
        //p1.PrintP();
    }



}