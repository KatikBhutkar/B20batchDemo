class Program
{
    static void Main()
    {
        //string[] names = new string[] { "Vishal", "Akash", "Mayur" };
        //string n = names[1];
        //Console.WriteLine(n); // Akash

        //names[1] = "Shital";
        //n = names[1];
        //Console.WriteLine(n); // Shital

        Student[] students = new Student[]
        { new Student() {Rollnumber = 101, Name = "KARTIK",city = "NAgpur" },
        new Student() {Rollnumber = 102, Name = "Kunal",city = "Yavatmal" },
        new Student() {Rollnumber = 103, Name = "Ram",city = "Bhandara" },
        new Student() {Rollnumber = 104, Name = "Chetan",city = "Wardha" },
        new Student() {Rollnumber = 105, Name = "Gauri",city = "Yavatmal" }
        };

        Institute i1 = new Institute(students);

        string name = i1[106]; // getting value
        Console.WriteLine(name);

        //i1[105] = "KKK";      // setting value
        //name = i1[105];
        //Console.WriteLine(name);


        Console.ReadLine();
    }

}


class Student
{
    public string Name { get; set; }
    public int Rollnumber { get; set; }
    public string city { get; set; }


}

class Institute
{
    public string InstituteName { get; set; }
    private Student[] _student;

    public Institute(Student[] students)
    {
        _student = students;

    }

    public string this[int rn]
    {

        get
        {
            for (int i = 0; i < _student.Length; i++)
            {
                if (_student[i].Rollnumber == rn)
                {
                    return _student[i].Name;
                }


            }
            return $"Student Rollnumber is not Found {rn}";
        }



        set
        {
            for (int i = 0; i < _student.Length; i++)
            {
                if (_student[i].Rollnumber == rn)
                {

                   _student[i].Name = value;
                }


            }

        }

    }

    //public Student this[string name]
    //{
    //    get 
    //    { 
    //      for(int i=0 )
        
    //    }
     
    
    
    //}


}

