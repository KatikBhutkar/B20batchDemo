class Program
{
    static void Main()
    {
        Console.WriteLine("Please Enter a first Number");
        int num = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Please Enter a second Number");
        //int n2= Convert.ToInt32(Console.ReadLine());

        //int n3 = n1; // third Variable
        //n1 = n2;
        //n2 = n3;

        //n1 = n1 + n2;// 10+20=30
        //n2 = n1 - n2;// 30-20=10
        //n1= n1 - n2;// 20

        // Console.WriteLine($"The first number : {n1}\n The second number : {n2}");
        
        bool b1 = false;
        int i = 0;

        for (i=2; i < num / 2; i++)
        {
            if (num % i == 0)
            {
                Console.Write($" number {num} is divisible by {i},  ");
                b1 = true;
                //break;
            }
            
        }
        if (b1)
        {
            Console.WriteLine($"The number is not Prime : {num}");
        }
        else
        {
            Console.WriteLine($"The number is Prime : {num}" );
        }


        Console.ReadLine();
    }




}