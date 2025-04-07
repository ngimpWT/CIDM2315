namespace Homework9;
using System.Linq;                                                                    
public class Program
{
    public static void Main()
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");
        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        // Add key-value pairs
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);
        //Adds Tom if Tom does is not already present
        if(gradebook.ContainsKey("Tom") == false)
        {
            gradebook.Add("Tom", 3.3); //Adds Tom to gradebook
            Student Tom = new Student(555, "Tom"); //Adds Tom to student_list and assigns ID
        }
        // iterate all pairs with foreach
        double totalGPA = 0;
        int countGPA = 0;
        foreach(var stu in gradebook)
        {
            totalGPA += stu.Value;
            countGPA++;
        }
        if (countGPA > 0)
        {
            double averageGPA = totalGPA/countGPA;
            Console.WriteLine($"Q2: The average GPA is: {averageGPA}");
            foreach(var stu in gradebook)
            {
                if(averageGPA < stu.Value)
                {              
                    string name = stu.Key;
                    Student.FindStudentInfo(name); //calls method for each relevant student
                }
            }
        }
    }
}
class Student
{
    private int studentID { get; set; }
    private string studentName { get; set; }
    public void PrintInfo() //Prints student info
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    public static List<Student> student_list = new List<Student>();
    public Student(int inputID, string inputName) //Constructor
    {
        studentID = inputID;
        studentName = inputName;
        student_list.Add(this);
    }
    public static void FindStudentInfo(string x) //Method finds relevant student info and prints
    {
        foreach(Student k in student_list)
        {
            if (k.studentName == x)
                Console.WriteLine($"Student ID: {k.studentID}, Student Name: {k.studentName}");
        }
    }

}