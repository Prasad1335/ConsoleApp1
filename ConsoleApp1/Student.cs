// See https://aka.ms/new-console-template for more information
public class Student
{
    public int StudentID;
    public string StudentName;
    public int Age;
    public int StandardID;

    string s = new string('-', 20);

    public string StandardName;

    public List<Student> Print()
    {
        List<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
            new Student() { StudentID = 2, StudentName = "Steve", Age = 21, StandardID = 1 } ,
            new Student() { StudentID = 3, StudentName = "Bill", Age = 18, StandardID = 2 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
        };
        return studentList;
    }



    public void AgeGreaterThan()
    {
       

        Console.WriteLine(s + "  Age is gratter 18 query expression" + s);
        var result = from s in Print()
                     where s.Age > 18
                     select s;

        foreach (var str in result)
        {
            Console.WriteLine(str.StudentID + " " + str.StudentName + " " + str.Age);
        }


        // ----------------------------------------------------------------------------------------
        Console.WriteLine(s + "  Age is gratter 18 method expression" + s);
        var std = Print().Where(s => s.Age > 18).ToList<Student>();

        foreach (var str in std)
        {
            Console.WriteLine(str.StudentID + " " + str.StudentName + " " + str.Age);
        }

    }


    public void AgeGreaterThan12AndLessThan20()
    {

        Console.WriteLine(s + "   Age is gratter 12 and less 20 query expresstion " + s);
        var student = from s in Print()
                      where s.Age > 12 && s.Age < 20
                      select s;

        foreach (var str in student)
        {
            Console.WriteLine(str.StudentID + " " + str.StudentName + " " + str.Age);
        }

        Console.WriteLine(s + "   Age is gratter 12 and less 20 method expresstion " + s);

        var stud = Print().Where(s => s.Age > 12 && s.Age < 20).ToList<Student>();
        foreach (var str in stud)
        {
            Console.WriteLine(str.StudentID + " " + str.StudentName + " " + str.Age);
        }
    }


    public void StudentGrpByStandardID()
    {
        Console.WriteLine(s + "  list students group by StandardID  query expresstion " + s);

        var st = from ss in Print() group ss by ss.StandardID;

        foreach (var str in st)
        {
            Console.WriteLine(str.Key);
            foreach (var strr in str)
            {
                Console.WriteLine(strr.StandardName + "\t" + strr.Age);

            }
        }
        //----------------------------------------------------------------------------
        Console.WriteLine(s + "  list students group by StandardID  method expresstion " + s);

        var stt = Print().GroupBy(s => s.StandardID);

        foreach (var str in stt)
        {
            Console.WriteLine("  StandardID >> " + str.Key + "\n");
            foreach (var strr in str)
            {

                Console.WriteLine(strr.StudentID + " " + strr.StudentName + " " + strr.Age);

            }
            Console.WriteLine(s);

        }

    }

}



