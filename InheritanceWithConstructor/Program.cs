using System.Globalization;

class Program
{
    static void Main()
    { 
     // Person p1 = new Person();
    // Employee e1 = new Employee();
       // Person p1 = new Employee();
        Employee e2 = new Employee("Good Morning!!!!",1000);
       // e2.Print();

        Console.ReadLine();
    }


}

class Mammals
{
    public Mammals()
    {
        Console.WriteLine("Mammals() called");
    }
}

class Person
{
    public string Name = "Person"; 
    public Person(string message)    
    {
        Console.WriteLine("Person(string message) called");
    
    }


    public Person(int num)
    {
        Console.WriteLine($"Person(int num) : {num} called");
    
    }
}




class Employee : Person
{
    public string Name = "Employee";
    //public Employee()
    //{
    //    Console.WriteLine("Employee() Called");


    //}

    public Employee(string message): base(message)
    {
        Console.WriteLine("Employee(string message) called ");
    }

    public Employee(string message,int num) : base(num)
    {
        Console.WriteLine("Employee(string message,int num) called ");
    }
    public void Print()
    {
        Console.WriteLine(base.Name);
    }
}