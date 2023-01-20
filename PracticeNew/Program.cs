
class Program
{

    //static void Main()
    //{
    //    Console.WriteLine("Main Stars Here");

    //    PrintK();                                             // Calling Method

    //    //PrintR();
    //    string s1 = PrintR();
    //    Console.WriteLine(s1);

    //    PrintS("RRRRRRR");

    //    int r1=PrintSH("SSSSSSS");
    //    Console.WriteLine(r1);

    //    Console.WriteLine("Main Ends Here");



    //}
    /////
    //// method does not have return type and parameters
    //static void PrintK()
    //{                                                        // Called Method
    //    Console.WriteLine("PrinTK() Method");

    //}

    //// method has return type and no parameters

    //static string PrintR()
    //{
    //    Console.WriteLine("PrintR() Method");
    //    return "HELLO from PrintR() Method";

    //}

    //// method has no return type and has parameters

    //static void PrintS(string name)
    //{
    //    Console.WriteLine($"Hello,{name}");
    //}

    //// method has return type and has parameters
    //static int PrintSH(string name)
    //{
    //    return name.Length; 
    //}



    //  Main Method = Calling Method
    static void Main()
    {

        //string r1 = PrintR("Kartik"); // method = Argument
        //Console.WriteLine(r1);

        //string k1 = PrintR("RRR"); // Method argument
        //Console.WriteLine(r1);
        //string s1 = PrintR(r1);
        //Console.WriteLine(s1);
        //string s2 = PrintR(k1);
        //Console.WriteLine(s2);

        PrintKK(true);

        
    }



    //  PrintR() = Called Method

    //static string PrintR(string name)  // name -- Method Parameter
    //{
    //    return "Good Morning " + name;


    //}

    static void PrintKK(bool b)
    {
        if (!b)
        {
           
            return;
        }
        Console.WriteLine("Code Executed from method PrintKK");
    }

}