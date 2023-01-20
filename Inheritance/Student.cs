class Student
{
    public string FirstName;
    public string LastName;
    public string City;
    public void PrintFullName()
    {
        Console.WriteLine($"FirstName : {FirstName} " +
            $"LastName : {LastName}");
    
    }

    public void Details()
    {
        Console.WriteLine($"FirstName : {FirstName}\n" +
            $"LastName : {LastName}\n" +
            $"City : {City}\n");
    
    }




}
