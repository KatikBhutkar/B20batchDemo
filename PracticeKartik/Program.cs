

class Program
{
    static void Main()
    {
        int Totalbill = 0;
        string choice = "";
        do
        {
            Console.WriteLine("-----@Menu-----");
            Console.WriteLine($"1) Cold cofee\t 2) Sandwich\t 3) cold drinks\t 4) Pastries");
            Console.WriteLine("What would you like to have?");
            int order = int.Parse(Console.ReadLine());



            switch (order)
            {
                case 1:
                    Console.WriteLine("You ordered : COLD COFEE");
                    Totalbill += 25;
                    break;

                case 2:
                    Console.WriteLine("You ordered : SANDWICH");
                    Totalbill += 40;
                    break;

                case 3:
                    Console.WriteLine("You ordered : COLD DRINKS");
                    Totalbill += 30;
                    break;

                case 4:
                    Console.WriteLine("You ordered : PASTRIES");
                    Totalbill += 35;
                    break;

                default:
                    Console.WriteLine($"{order} : Not available ");
                    break;


            }

            Console.WriteLine("Do you want to continue?");
            choice = Console.ReadLine().ToUpper();

        }
        while (choice == "Y" || choice == "YES");

        Console.WriteLine();
        Console.WriteLine(">>>>>>TOTALBILL<<<<<<");

        Console.WriteLine();
        Console.WriteLine($"Total Bill amount : {Totalbill} rs");

        Console.WriteLine("Thank You 'Visit Again'");





        //    int totalprice = 0;
        //    string choice = "";
        //    int totalcitrizine = 0, totalcolddac = 0, totalpainkiller = 0, totaldcoldtotal = 0;
        //    Console.WriteLine("-----#medicines#-----");
        //    do
        //    {

        //        Console.WriteLine("citrizine\tcolddac\tpainkiller\tdcoldtotal");
        //        Console.WriteLine("medicines priscribed by doctor");
        //        string order = Console.ReadLine();


        //        switch (order)
        //        {
        //            case "citrizine":
        //                Console.WriteLine("how many citrizine tabs?");
        //                int tc = int.Parse(Console.ReadLine());
        //                totalcitrizine = tc;
        //                //totalprice += 50;
        //                break;

        //            case "colddac":
        //                Console.WriteLine("how many colddac tabs?");
        //                int td = int.Parse(Console.ReadLine());
        //                totalcolddac = td;
        //                //totalprice += 100;
        //                break;

        //            case "painkiller":
        //                Console.WriteLine("how many painkiller?");
        //                int tp = int.Parse(Console.ReadLine());
        //                totalpainkiller = tp;
        //                // totalprice += 120;
        //                break;

        //            case "dcoldtotal":
        //                Console.WriteLine("how many dcoldtotal");
        //                int tt = int.Parse(Console.ReadLine());
        //                totaldcoldtotal = tt;
        //                //totalprice += 125;
        //                break;

        //            default:
        //                Console.WriteLine($"{order} = not in stock ");
        //                break;


        //        }
        //        Console.WriteLine("do you want to continue?");
        //        choice = Console.ReadLine().ToUpper();


        //    } while (choice == "Y" || choice == "YES");


        //    if (totalcitrizine > 0 || totalcolddac > 0 || totalpainkiller > 0 || totaldcoldtotal > 0 )
        //    {
        //        Console.WriteLine("------bill receipt------");
        //    }


        //    if (totalcitrizine > 0)
        //    {
        //        Console.WriteLine($"citrizine {totalcitrizine}*50:{totalcitrizine * 50}");
        //        totalprice += totalcitrizine * 50;
        //    }
        //    if (totalcolddac > 0)
        //    {
        //        Console.WriteLine($"colddac {totalcolddac} * 100:{totalcolddac * 100}");
        //        totalprice += totalcolddac * 100;
        //    }
        //    if (totalpainkiller > 0)
        //    {
        //        Console.WriteLine($"painkiller {totalpainkiller}* 120:{totalpainkiller * 120}");
        //        totalprice += totalpainkiller * 120;
        //    }
        //    if (totaldcoldtotal > 0)
        //    {
        //        Console.WriteLine($"dcoldtotal {totaldcoldtotal}* 125:{totaldcoldtotal * 125}");
        //        totalprice += totaldcoldtotal * 125;
        //    }

        //    if (totalprice>0)
        //    {
        //        Console.WriteLine("--------------------------------");
        //        Console.WriteLine(">>>>>totalbill<<<<<");

        //        Console.WriteLine($"total bill of medicine = {totalprice}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No Bill");

        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("Thank you .Visit Again");



    }




    // Sorting Array in C# - Highest Value in Array.

    //int[] array = { 2, 11, 15, 1, 7, 99, 6, 85, 4 };
    //Array.Sort(array); //sorting array  
    //Array.Reverse(array); // Reverse Sorting array value  
    //Console.WriteLine("Highest Value In Array " + array[0]);

    // Console.WriteLine();

    //foreach (var result in array)
    //{
    //    Console.Write(result + " "); // Array values   
    //}

}











