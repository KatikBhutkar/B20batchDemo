using l1 = Library1;
using l2 = Library2;
class Program
{
    static void Main()
    {
        //Library1.Calculator c1 = new Library1.Calculator();
        //l1.Calculator c1 = new l1.Calculator();

        //int result = c1.Add(50, 40);
        //Console.WriteLine(result);


        //Library2.Calculator c2 = new Library2.Calculator();

        //l2.Calculator c2 = new l2.Calculator();
        //result = c2.Sub(50,30);
        //Console.WriteLine(result);

        Utility u1 = new Utility();
        int result = u1.Getotp();
        Console.WriteLine(result);


        Console.ReadLine();
    }


}