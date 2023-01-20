class Student : Person
{
    public string StudenName;
    public string City;
    public string Age;


    public void details()
    {
        Console.WriteLine($"StudenName {StudenName}\n" +
            $"City : {City}\n" +
            $"Age : {Age}");
    
    }


}