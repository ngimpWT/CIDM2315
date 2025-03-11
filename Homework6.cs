namespace Homework6;
class Program
{
    static void Main(string[ ] args)
        {
            //Answer Q1 and Q2
            Professor professor1 = new Professor("Alice", "Java", 9000);
            Professor professor2 = new Professor("Bob", "Math", 8000);
            professor1.PrintInfo();
            professor2.PrintInfo();
            Student student1 = new Student ("Lisa", "Java", 90);
            Student student2 = new Student ("Tom", "Math", 80);
            student1.PrintInfo();
            student2.PrintInfo();
            double salaryDifference = professor1.getSalary() - professor2.getSalary();
            Console.WriteLine($"The Salary difference between {professor1.profName} and {professor2.profName} is: {salaryDifference}");
            double gradeSum = student1.getGrade() + student2.getGrade();
            Console.WriteLine($"The total grade of {student1.studentName} and {student2.studentName} is: {gradeSum}");
        }
}
class Professor
{
    public string profName;
    public string classTeach;
    private double salary;
    public Professor (string name, string teach, double profSalary)
        {
        profName = name;
        classTeach = teach;
        salary = profSalary;
        }
    public double getSalary()
        {
            return salary;
        }
    public void PrintInfo()
        {
            Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {getSalary()}");
        }             
}
class Student
{
    public string studentName;
    public string classEnroll;
    public double studentGrade;
    public Student (string name, string enroll, double grade)
        {
            studentName = name;
            classEnroll = enroll;
            studentGrade = grade;
        }
    public double getGrade()
        {
            return studentGrade;
        }
    public void PrintInfo()
        {
            Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {getGrade()}");
        }
}