class Program
{
    static void Main()
    {
        //int totalBill = 0;
        //string choice = "";

        //Console.WriteLine("---Menu---");
        //do
        //{

        //    Console.WriteLine($"1) Pastries\t 2) Cookies\t 3) CAKE\t 4) Sandwich");
        //    Console.WriteLine("What would you like to have??");
        //    int order = int.Parse(Console.ReadLine());
        //    int QP = 0, QC = 0, QK = 0, QL = 0, QS = 0;

        //    switch (order)
        //    {

        //        case 1:
        //            Console.WriteLine("You ordered : Pastries");
        //            Console.WriteLine("How many you want??");
        //            int pst = int.Parse(Console.ReadLine());
        //            QP+= pst;
        //            totalBill+= pst;
        //            break;
        //        case 2:
        //            Console.WriteLine("You ordered : Cookies");
        //            Console.WriteLine("How many you want??");
        //            int cook=int.Parse(Console.ReadLine());
        //            QC+= cook;
        //            totalBill+= cook;
        //            break;
        //        case 3:

        //            Console.WriteLine("You ordered : Cake");
        //            Console.WriteLine("How many you want??");
        //            int kake = int.Parse(Console.ReadLine());
        //            QC+= kake;
        //            totalBill+= kake;
        //            break;
        //        case 4:
        //            Console.WriteLine("You orderd : Sandwich");
        //            Console.WriteLine("How many you want??"); 
        //            int SD=int.Parse(Console.ReadLine());
        //            QS = SD;
        //            totalBill += QS;
        //            break;
        //        default:
        //            Console.WriteLine("Nothing else");
        //            break;

        //    }


        //    Console.WriteLine("Do you want to continue?");
        //    choice = Console.ReadLine().ToUpper();


        //}
        //while (choice == "Y" || choice == "YES");


        //Console.WriteLine();
        //Console.WriteLine(">>>>>>>>Totalaccount<<<<<<<");

        //Console.WriteLine();
        //Console.WriteLine($"Total Bill Amount : {totalBill} rs");
        //Console.WriteLine("THank You VISIT AGAIN");

        #region Fibonacci series

        //int n1 = 0, n2 = 1, n3, i, number;
        //Console.WriteLine("Please Enter a Number");
        //number= int.Parse(Console.ReadLine());

        //Console.Write(n1 + " " + n2 + " ");

        //for (i = 2; i < number; ++i)
        //{

        //    n3 = n1 + n2;
        //    Console.Write(n3 + " ");
        //    n1 = n2;
        //    n2 = n3;


        //}

        #endregion Fibonacci series

        //Public1 p1 = new Public1();   // NOT WORKING
        //p1.Print(args);
        

    }
    #region Factorial Number
    class Public1
    {
        public static void Print(string[] args)
        {
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
        }

    }







    #endregion Factorial Number





}