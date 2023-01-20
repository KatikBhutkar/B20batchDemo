class program 

{
  static void Main()
    {
       short v1 = 10;   // Short => int
       int v2 = v1;
       Console.WriteLine(v2);

       short v3 = (short)v2;  //int => short      by Type Conversion
       Console.WriteLine(v3);

       float V4 = v2;          // float => int    done because float takes 4byte and int takes 4byte memory
       Console.WriteLine(V4);

    
        int v5 = (int)V4; 
        Console.WriteLine(v5);

        float V6 = 100;
        int V7 = (int)V6;        // float => int
        Console.WriteLine(V7);

        long v8 = 101;
        float V9 = v8;
        Console.WriteLine(v8);

        int v10 = (int)v8;
        Console.WriteLine(v10);

        float v11 = 10.2f;
        double v12 = v11;          // float=> double
        Console.WriteLine(v12);

        double v13 = 1000.756;
        float v14 = (float)v13;   // double => float
        Console.WriteLine(v14);

        decimal v15 = 123.0352222m;
        float v16 = (float)v15;    // decimal => float
        Console.WriteLine(v16);

        string v6 = "100";
        int v17 = Convert.ToInt32(v6);  // string => int
        Console.WriteLine(v17);

        v6 = "abc";
        int v18;
        int.TryParse(v6,out v18);   // string => int     by parse/Tryparse Method
        Console.WriteLine(v18);

        string v19 = "TRUE";
        bool v20 = bool.Parse(v19);   // string => bool   by parse method
        Console.WriteLine(v20);

        v6= "abc";
        int v21;
        bool status = int.TryParse(v6,out v21);
        Console.WriteLine(status);
        Console.WriteLine(v21);













      // String firstname = "Anil";
      //firstname = firstname.Remove(firstname.Length-1);
      // Console.WriteLine(firstname);

    Console.ReadLine();





    }





}

    







