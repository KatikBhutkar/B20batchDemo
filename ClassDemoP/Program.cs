class program
{
    static void Main()
    {
        Student s1 = new Student()
        {
            Firstname = "Kartik",
            Lastname  = "Bhutkar",
            Cityname  = "Nagpur" ,
            Country   = "INDIA"
        };
      //  s1.newk();   
        
        // class fields
        Student s2 = new Student();
        s2.Firstname = "Kartik";
        s2.Lastname = "Bhutkar";
        s2.Cityname = "NAGPUR";
        s2.Country = "INDIA";
        s2.PrintK();
        s2.newk();
        Console.ReadLine();
    }

        
    
   
}


class Student
{   public  string Firstname;
    public  string Lastname;
    public  string Cityname;
    public  string Country;

    public void PrintK()
    {
       Console.WriteLine($"FullName : {Firstname}  {Lastname}");

    }

    public void newk()
    {
        PrintK(); 

        Console.WriteLine($"****** Details ****** \n Cityname : {Cityname}\n Country : {Country}");
    
    }

}