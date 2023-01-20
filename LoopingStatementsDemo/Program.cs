using System.Globalization;

class program
{
    static void Main()
    {

        //int i = 1;

        //do
        //{
        //    Console.Write("*\t");

        //    i++;
        //} while (i <= 5);

        //Console.ReadLine();


        //int i = 1;
        //while (i<= 5)
        //{ 
        //   Console.WriteLine(i);
        //    i++;
        //}

        //for (int i = 1; i <= 5; i++)
        //{
        //    Console.WriteLine(i);       
        //}

        //for (int i = 1; i <= 5; i++)
        //{
        //    if (i == 2 && i==3)
        //    {                                 // ek time pe i=2 and i=3 nahi rehta
        //       continue;

        //    }
        //    Console.WriteLine(i);

        //}
        //Console.WriteLine("Main is here");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
            if (i == 2)
            {
                i = 6;
            }


        }

        //for (int i = 1; i <= 5; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("*\t");
        //    }
        //   Console.WriteLine();
        //}



    }
}