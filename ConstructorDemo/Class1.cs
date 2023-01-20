class Student
{
    public string FirstName;
    public string LastName;
    public static string CourseName;

    //public Student()
    //{
    //    //Console.WriteLine("Constructor called");
    //   FirstName = "Vhassh";
    //   LastName = "Technologies";
    //}



    //parameterless constructor
     public Student() 
    {
        Console.WriteLine("Public constructor() called");
    }


    //Parameterized Constructor

    //public Student(string fn, string ln)
    //{
    //    FirstName = fn;
    //    LastName = ln;
    //}

    // Parameterized constructor = copy Constructor 
    public Student(Student s)
    {
        FirstName = s.FirstName;
        LastName = s.LastName;
    }

    //Parameterized Constructor
    public Student(string Firstname,string Lastname)
    {
       this.FirstName = FirstName;
       this.LastName = LastName;
    }

    //static constructor

    static Student()
    {
        CourseName = "Dot Net";
        Console.WriteLine("static constructor() called");
    }
    public void PrintFullName()
    {
        Console.WriteLine($"FullName : {FirstName} {LastName}");
     
    }

   

}