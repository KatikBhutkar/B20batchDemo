using System;

class program 
{
    static void Main()

    {
        //Console.WriteLine("Please enter a first number");
        //int a = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Please enter a Second number");
        //int b = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Please enter a third number");
        //int c = Convert.ToInt32(Console.ReadLine());


        //if (a > b && a > c)
        //{
        //    Console.WriteLine($"{a} is greater than {b} and {c}");

        //}
        //else if (b > a && b > c)
        //{
        //    Console.WriteLine($"{b} is greater than {a} and {c}");

        //}
        //else 
        //{

        //Console.WriteLine($"{c} is greater than {a} and {b}");



        // Nested If Examples

        //if (a>b)
        // {
        //    if (a > c)
        //    {
        //        Console.WriteLine($"{a} is greater than {b} and {c}");

        //    }
        //    else if (a < c)
        //    {
        //        Console.WriteLine($"{c} is greater than {b} and {c}");

        //    }
        //    else
        //    {
        //        Console.WriteLine($"{a} and {c} are same and greater than {b}");
        //    }

        //  }
        //else
        //{   if (b > c)
        //    {

        //        Console.WriteLine($"{b} is greater than {a} and {c}");
        //    }
        //    else if(b < c)
        //    {
        //        Console.WriteLine($"{c} is greater then {b} and {a}");

        //    }
        //    else
        //    {
        //        Console.WriteLine($"{b} and {c} are same and greater than {a}");
        //    }



        // }

        //  Console.WriteLine("Please Enter a Number");
        //   int num = int.Parse(Console.ReadLine());


        //if (num % 3 == 0 && num % 5 == 0)
        //{
        //    Console.WriteLine($"{num} is divisible by 3 and 5");

        //}
        //else if (num % 3 == 0)
        //{
        //    Console.WriteLine($"{num} is divisible by 3");
        //}
        //else if (num % 5 == 0)
        //{
        //    Console.WriteLine($"{num} is divisible by 5 ");
        //}
        //else
        //{
        //    Console.WriteLine($"{num} is not divisible by 3 and 5");
        //}


        // int result = a > b ? a : b;
        //int result = (a > b ) ? (a > c ?a : c) : (b > c ? b : c);
        //Console.WriteLine($"{result} is bigger number");

        Console.WriteLine("Enter a city");
        string city= Console.ReadLine();

        switch (city.ToUpper())
        {
            case "MUMBAI":
                Console.WriteLine("Pritesh: Mumbai");
                break;
            case "PUNE":
                Console.WriteLine("Shubham: PUNE");
                break;
            case "YAVATMAL":
                Console.WriteLine("Vikas: YAVATMAL");
                break;
            default: Console.WriteLine("UNKNOWN");
                break;
        }



            Console.ReadLine();
    
    
    
    }
 






}