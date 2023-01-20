class program 
{ 
    static void Main()
    {
        byte v1 = 10;
        Console.WriteLine(v1);
        Console.WriteLine($"size of byte: {sizeof(byte)} minimum value:{byte.MinValue} maxvalue :{byte.MaxValue}");
        //Console.WriteLine(byte.MinValue);
        //Console.WriteLine(byte.MaxValue);

        short v2 = 10;
        Console.WriteLine(v2);
        Console.WriteLine($"size of short: {sizeof(short)} minimum value:{short.MinValue} maxvalue :{short.MaxValue}");

        int v3 = 10;
        Console.WriteLine(v3);
        Console.WriteLine($"size of int: {sizeof(int)} minimum value:{int.MinValue} maxvalue :{int.MaxValue}");

        long v4 = 10;
        Console.WriteLine(v4);
        Console.WriteLine($"size of long: {sizeof(long)} minimum value:{long.MinValue} maxvalue :{long.MaxValue}");

        float v5 = 10.456f;
        Console.WriteLine(v5);
        Console.WriteLine($"size of float: {sizeof(float)} minimum value:{float.MinValue} maxvalue :{float.MaxValue}");

        double v6 = 100.3355;
        Console.WriteLine(v6);
        Console.WriteLine($"size of double: {sizeof(double)} minimum value:{double.MinValue} maxvalue :{double.MaxValue}"); 


        decimal v7 = 100.12233343m;
        Console.WriteLine(v7);
        Console.WriteLine($"size of decimal: {sizeof(decimal)} minimum value:{decimal.MinValue} maxvalue :{decimal.MaxValue}");

        bool V8 = true;
        Console.WriteLine(V8);
        Console.WriteLine($"siz of bool: {sizeof (bool)}");



        char division = 'A';
        Console.WriteLine(division);
        Console.WriteLine($"size of Char: {sizeof (char)}");

        string i = "100";
        Console.WriteLine(i);
        // Console.WriteLine($"{sizeof (String) }");

        char currency = '$';
        Console.WriteLine(currency);
        Console.WriteLine($"{sizeof(char)}");

        string name = "Kartikeyaa";
        Console.WriteLine(name);
        


        Console.ReadLine();
    }



}
 