class program 
{  
    static void Main()
    {
       
        Square c1 = new Square();
        Console.WriteLine("Please Enter a Number");
        c1.length = Convert.ToInt32(Console.ReadLine());
       
        c1.Area();

        //circle c2 = new circle();
        //c2.Radius = 10;
        //c2.Area();

        
    }

   

}

class Square
{
    
    public int length;
   

    public void Area()
    {
      Console.WriteLine($"Area of Square having length  = {length * length}");
    
    }
 

}