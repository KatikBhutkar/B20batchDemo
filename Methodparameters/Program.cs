using System.Runtime.InteropServices;

class program
{

    static void Main()
    {
        //    PrintA(10);
        //    PrintA();         // Without Passing Argument(optional parameter)
        //    PrintA(400);

        //PrintB(10, 30);
        //PrintB(05, 45);

        PrintC(b:10);
        PrintC(a: 10, b: 5, c: 15);
    }


    static void PrintA(int num = 137)
    {
        Console.WriteLine($"The parameter value is {num}");
    }


    static void PrintB( int a, int b)
    {

        Console.WriteLine($"Sum : {a} + {b} = {a+b}");
    
    }

    static void PrintC([Optional]int a,int b,[Optional]int c )
    {
        Console.WriteLine($"Sum : {a} + {b} +{c}= {a+b+c}");
    }

       // Params Example
    static void PrintSum1(int a, int b, params int[] numbers)
    {
        Console.WriteLine($"sum : {a}+{b}={a + b}");

        if (numbers != null && numbers.Length > 0)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Sum : {sum}");
        }
        else
        {
            Console.WriteLine("Empty Array");
        }

    }




}