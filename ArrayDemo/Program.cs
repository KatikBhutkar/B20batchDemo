class program
{
    static void Main()
    {

        // string[] names = new string[] { "Ramesh", "Himesh", "Karan", "jassi" ,"MR Bean"};

        //Console.WriteLine(names[0]);

        //Console.WriteLine(names[2]);

        //for(int i=0;i<names.Length;i++)
        //{

        //    Console.Write($"{names[i]}  ");

        //}

        //  Console.WriteLine();
        //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] % 2 == 0)
        //    {
        //        Console.WriteLine($"{numbers[i]}: EVEN ");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{numbers[i]}: ODD ");

        //    }
        //}



        //// Highest number 
        //int j = 0;
        //int i = 0;
        //int[] nums = { 10, 78, 200, 54, 43, 21, 38 };
        // int highest = 0;

        //for ( i=0; i< nums.Length; i++)
        //{
        //        highest= nums[i];
        //    for (j= 0; j < nums.Length; j++)
        //    {
        //        if (nums[i] == nums[j])

        //            continue;

        //        if (nums[j] > highest)
        //        {
        //            highest = nums[j]; 
        //        }
        //    }


        //}

        //Console.WriteLine($"highest number is {highest}");




        //// LOWEST NUMBER


        //int i = 0;
        //int j = 0;
        //int[] nums = { 10, 78, 200, 54, 43, 21, 38 };
        //int lowest = 0;

        //for (i = 0; i < nums.Length; i++)
        //{
        //    lowest = nums[i];
        //    for (j = 0; j < nums.Length; j++)
        //    {
        //        if (nums[i] == nums[j])

        //            continue;

        //        if (nums[j] < lowest)
        //        {
        //            lowest = nums[j];
        //        }
        //    }


        //}
        //Console.WriteLine($"Lowest number is {lowest}");




            int i = 0;
            int j = 0;
            int Result;
            int[] nums = { 101, 99, 987, 800, 989 };
            
            for (i = 0; i < nums.Length; i++)
            {
            for (j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    Result = nums[i];

                    nums[i] = nums[j];

                    nums[j] = Result;
                }
            }
        }
            Console.WriteLine("Largest: " + nums[nums.Length - 1]);
       
            Console.WriteLine("Second Largest: " + nums[nums.Length - 2]);

            Console.ReadLine();



    }
    




            
}



