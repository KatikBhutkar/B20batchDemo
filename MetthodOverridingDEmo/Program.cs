class Program
{
    static void Main()
    {

        //Person p1 = new Person("KArtik","Bhutkar");
        ////p1.FirstName = "Lalit";
        ////p1.LastName = "Kadam";
        //p1.PrintFullname();

        //Person p2 = new Employee("Anil", "Rathod");
        //p2.PrintFullname();

        //Person p3 = new PermanentEmployee("Arijit", "Singh");
        //p3.PrintFullname();

        Person[] PK = new Person[5];
        PK[0] = new Person("KAtik", "Bhutkar");
        PK[1] = new Employee("Anil", "Rathod");
        PK[2] = new PermanentEmployee("Arijit", "Singh");
        PK[3] = new Student("Sumit", "Deshmukh");
        PK[4] = new Celebrity("Kabir", "Singh");

        for (int i = 0; i < PK.Length; i++)
        {
            PK[i].PrintFullname();

        
        }

    }

}

class Person
{
    public string FirstName;
    public string LastName; 
    public virtual void PrintFullname()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName}");  
    
    }

    public  Person(string fn, string ln)
    {
        FirstName = fn;
        LastName = ln;
    
    } 

    
}

class Employee : Person
{
    public Employee(string fn, string ln) : base(fn, ln)
    {}

    public override void PrintFullname()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName} : Employee");

    }

}

class PermanentEmployee : Employee
{
    public PermanentEmployee(string fn, string ln) : base(fn, ln)
    { }

    public override void PrintFullname()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName} : PermanentEmployee");

    }


}

class Student : Person
{
    public Student(string fn, string ln) : base(fn, ln)
    { }

    public override void PrintFullname()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName} : Student");

    }


}

class Celebrity : Person
{
    public Celebrity(string fn, string ln) : base(fn, ln)
    { }

    public override void PrintFullname()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName} : Celebrity");

    }


}
