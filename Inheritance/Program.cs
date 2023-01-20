class Program
{

    static void Main()
    {
        Console.WriteLine("Mains Start");

        Student s1 = new Student();
        {
            s1.FirstName = "Kartik";
            s1.LastName = "Aryan";
            s1.City = "Mumbai";
            s1.Details();
            s1.PrintFullName();
        }
    
    }



}