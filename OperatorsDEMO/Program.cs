
using System.Numerics;
using System.Runtime.Intrinsics.X86;

class program
{
    static void Main()
    {
      
        
        int v1 = 20;
        int v2 = v1;

        bool b1 = v1 == v2;
        Console.WriteLine($"v1 == v2 is {b1}");

        v2 = 30;

        b1 = v1 != v2;        
        Console.WriteLine($"v1 != v2 is {b1}");

        b1 = v1 > v2;
        Console.WriteLine($"{v1} > {v2} is {b1} ");

        v2 = 20;
        b1 = v1 >= v2;
        Console.WriteLine($"{v1}>= {v2} is {b1}");

        b1 = v1 <= v2;
        Console.WriteLine($"{v1} <= {v2} is {b1}");

        v1 = 20;
        v2 = 30;
        int v3 = 40;

        b1 = v1 < v2 && v2<v3;
        Console.WriteLine($"{v1}<{v2} && {v2}<{v3} is {b1} ");

        b1= v1 > v2 && v2 < v3 ;
        Console.WriteLine($"{v1}>{v2} && {v2}< {v3} is {b1}");

        b1 = v1 > v2 || v2 < v3;
        Console.WriteLine($"{v1}>{v2} || {v2}< {v3} is {b1}");


        b1 = v1 < v2 || v2 < v3;
        Console.WriteLine($"{v1}<{v2} || {v2}<{v3} is {b1} ");

        b1 = v1 < v2 || v2 > v3 || v1 == v3;
        Console.WriteLine($"{v1}<{v2} || {v2}>{v3} ||{v1}=={v3} is {b1} ");


        b1 = v1 < v2 || v2 > v3 && v1 == v3;
        Console.WriteLine($"{v1}<{v2} || {v2}>{v3} && {v1}=={v3} is {b1} "); // wont work 


        b1 = v1 < v2 || (v2 > v3 && v1 == v3);
        Console.WriteLine($"{v1}<{v2} || {v2}>{v3} && {v1}=={v3} is {b1} ");

        int a = 70;
        Console.WriteLine($"-a {-a}");

        b1 = true;
        Console.WriteLine(!b1);

        Console.ReadLine();

    }


}