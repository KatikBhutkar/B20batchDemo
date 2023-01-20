class Employee : Person
{
    public string Firstname;
    public string Lastname;
    public string Employeename;
    public string city;
    public int Age;

    public  new void  Printfullname()
    {
        Console.WriteLine($"FirstName : {Firstname} \t LastName : {Lastname} - Employee Method ");

    }

    public void Details()
    {
        Console.WriteLine($"-----Details----- \n" +
            $"Firstname  : {Firstname}\n Lastname : {Lastname}\n" +
            $"Employeename {Employeename}\n" +
            $"city {city}\n" +
            $"Age {Age} \n");
    
    }


}