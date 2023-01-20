using System.Diagnostics.CodeAnalysis;

class program
{

    static void Main()
    {
        #region Commented code
        //int i = 1;
        //do
        //{
        //    Console.WriteLine(i++);

        //} while (i <= 10);

        //int i = 1;
        //while (i <= 10)
        //{

        //    Console.WriteLine(i);
        //    i++;
        //}


        //int i = 1;
        //for (i = 1; i <= 10; i++)
        //{ 
        //  Console.WriteLine(i);


        //}

        //int i ;
        //double r ;
        //double sum = 0;
        //double avg;

        // Console.WriteLine("Please enter 10 numbers");
        //Console.WriteLine("-----------------------------");



        // EXAMPLE OF AVG AND SUM 

        // for (i = 0; i <= 3; i++)
        // {
        //     r = Convert.ToDouble(Console.ReadLine());
        //     sum += r;

        //     if (r % 2 == 0)
        //     {
        //         Console.WriteLine($"{r} Is Even Number");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{r} Is Odd Number");
        //     }


        // }

        //   avg = sum / 10.0;
        //   Console.WriteLine($"The sum of 10 number is : {sum}");


        //   Console.WriteLine($"The avg of 10 number is : {avg} ");



        //for(int i = 1,j = 1; i+j <= 10 ;i++,j++)
        //{ 
        //  Console.WriteLine($"value of :{i}  \t value of :{j}");

        //}





        //Console.ReadLine();



        // STAR PATTERN 

        //for (int i = 1; i <= 5; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {

        //        Console.Write("*");

        //    }
        //    Console.WriteLine();
        //}
        //for (int i = 1; i <= 4; i++)
        //{
        //    for (int j = i; j <= 4; j++)
        //    {

        //        Console.Write("*");

        //    }
        //    Console.WriteLine();
        //}    

        // STAR PATTERN 2


        //for (int i = 1; i <= 5; i++)
        //{
        //    for (int j = i; j <= 4; j++)
        //    {
        //        Console.Write(" ");

        //    }
        //    for (int k = 1; k <= i; k++)
        //    {

        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}
        //for (int i = 1; i <= 5; i++)
        //{
        //    for (int j = 2; j <= i; j++)
        //    {

        //        Console.Write(" ");

        //    }
        //    for (int k = i; k <= 5; k++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        // PRIME NUMBER CODE

        //int n, m; int flag =0;
        //Console.WriteLine("Please Enter a number to check Prime");

        //n = Convert.ToInt32(Console.ReadLine());
        //m = n / 2;

        //for (int i = 2; i <= m; i++)
        //{

        //    if (n % i == 0)
        //    {
        //        Console.WriteLine($"Entered number {n} is  not Prime");
        //        flag = 1;
        //        break;
        //    }

        //}


        //    if(flag== 0)
        //    {
        //        Console.WriteLine($"Entered number {n} is Prime");

        //    }



        //}

        // PRIME NUMBER CODE


        // int i = 2, j = 0;
        // Console.WriteLine("Enter a Number");
        //  int n = Convert.ToInt32(Console.ReadLine());

        //while (i <= n / 2)
        // {
        //     if (n%2==0)
        //     {
        //         j = 1;
        //         break;
        //     }
        //     i++;

        // }

        // if (j == 0)
        //     Console.WriteLine(n + " is Prime number");
        // else
        //     Console.WriteLine(n + " is not prime number");


        ///////////////////////////////////////

        //bool? b1 = null;

        //object b2 = "Kartik";

        //string s1 = (string)b2;


        // Console.WriteLine(s1);

        //object b4 = null;   

        //Console.WriteLine(b4);


        //int? k = null;

        //int R = k ?? 0;
        //Console.WriteLine(R);

        //string name = null;

        //String name1 = name.ToUpper();  
        //Console.WriteLine(name1);

        #endregion Commented code



        //string name = "Main";
        //Console.WriteLine(name);

        //PrintA(name);
        //Console.WriteLine(name);

        //PrintB(ref name);
        //Console.WriteLine(name);





        //static string PrintA(string name)
        //{

        //   return name = "Kartik"; 

        //}

        //static void PrintB( ref string name)
        //{ 
        //  name ="Kartik";
        //}


        //    int a = 20, b = 5, add, sub, mul, div;
        //    Operation(a, b, out add, out sub, out mul, out div);
        //    Console.WriteLine($"Addition :{add}");
        //    Console.WriteLine($"Substraction :{sub}");
        //    Console.WriteLine($"Multiplication :{mul}");
        //    Console.WriteLine($"Division :{div}");



        //}


        //static void Operation(int a,int b,out int add,out int sub,out int mul,out int div)
        //{ 
        //    add= a + b;
        //    sub= a - b;
        //    mul= a * b;
        //    div= a / b;

        //}


        ////METHOD PARAMETERS

        //int[] arr = new int[]{ 10, 20, 30, 45 };
        //PrintSum(arr);

        //PrintSum(new int[] { 10, 20, 30, 45 });

        //int[] arr1 = null;
        //PrintSum(arr1);
        //PrintSum(null);
        //PrintSum(10,20,30,45);  
        //PrintSum();


      
    
       
            int x, y;
            int z = 5;
            for (x = 1; x <= z; x++)
            {
                for (y = x; y <= z; y++)
                {
                    Console.Write((char)(y + 64));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
       
    




    }



    //static void PrintSum(params int[] numbers)
    //{
    //    if (numbers != null && numbers.Length > 0)
    //    {
    //        int sum = 0;
    //        for (int i = 0; i < numbers.Length; i++)
    //        {
    //            sum += numbers[i];

    //        }
    //        Console.WriteLine($"Sum : {sum}");


    //    }
    //    else
    //    {
    //        Console.WriteLine("Empty Array");
    //    }





    //}

}



