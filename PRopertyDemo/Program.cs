class program
{
    static void Main()
    {
        #region code1
        //Student s1 = new Student();
        //s1.GetRollnumber();   // setting values/ assigning values
        //s1.rollnumber = 1;
        //s1._name = "Kartik";
        //s1._passmark = 40;

        ////getting values 
        //Console.WriteLine($"Rollnumber : {s1.rollnumber}\n" +
        //    $"name : {s1._name}\n " +
        //    $"PassMark : {s1._passmark}\n ");

        #endregion code

        #region code2
        //Student s1 = new Student();
        //s1.rollnumber = 1;
        //s1.SetRollnumber(-1);  // rollnumber cannot be negative
        //s1.SetRollnumber(1);
        //s1._name = "RRR";
        //s1.SetName(null); // here if null is given then No Name is output
        //s1.SetName("Mahesh bhau");
        //s1._passmark = 22;

        //getting values
        //Console.WriteLine($"Rollnumber : {s1.GetRollnumber()}\n" +
        //    $"name : {s1.GetName()}\n " +
        //    $"PassMark : {s1.GetPassMark()}\n ");
        #endregion code2


        Student s1 = new Student();
        //  s1.GetRollnumber();   // setting values/ assigning values
        s1.Rollnumber = 1;
        s1.Name = "Kartik";
        // s1._passmark;
        s1._City = "NAGPUR";

        //getting values 
        Console.WriteLine($"Rollnumber : {s1.Rollnumber}\n" +
                          $"name : {s1.Name}\n " +
                          $"PassMark : {s1.Passmark}\n " +
                          $"City : {s1.City}");

        Console.ReadLine();
    }

}


//class Student
//{
//    private int rollnumber;
//    private string _name;
//    private int _passmark = 40;

//    public int GetRollnumber()
//    {
//        return rollnumber;

//    }

//    public void SetRollnumber(int rn)
//    {
//        if (rn > 0)
//        {
//            rollnumber = rn;
//        }
//        else
//        {
//            Console.WriteLine("Rollnumber cannot be negative");
//        }
//    }

//    public void SetName(string name)
//    {
//        _name = name;

//    }

//    public string GetName()
//    {
//        return string.IsNullOrEmpty(_name) ? " No Name " : _name;

//    }

//    public int GetPassMark()
//    {
//        return _passmark;


//    }

class Student
{
    private int _rollnumber;
    private string _name;
    private int passmark = 40;

    public int Rollnumber
    {
        get
        {
            return _rollnumber;

        }

        set
        {

            if (value > 0)
            {
                _rollnumber = value;
            }
            else
            {
                Console.WriteLine("Rollnumber cannot be negative");
            }

        }

    }

    public string Name
    {
        get
        {
            return string.IsNullOrEmpty(_name) ? "No Name" : _name;
        }

        set
        {
            _name = value;
        }

    }

    public int Passmark
    {
        get
        {
            return passmark;


        }

    }

    public string _City;
    public string City
    {
        get
        {
            return string.IsNullOrEmpty(_City) ? "No city" : _City;
        }

        set
        {
            _City = value;
        }
    }

}