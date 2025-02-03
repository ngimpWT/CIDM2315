namespace ifGrade;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pleae input a grade letter.");
        string gradeInput = Console.ReadLine();
        switch (gradeInput){
            case "A":
                Console.WriteLine("GPA point: 4");
                break;
            case "B":
                Console.WriteLine("GPA point: 3");
                break;
            case "C":
                Console.WriteLine("GPA point: 2");
                break;
            case "D":
                Console.WriteLine("GPA point: 1");
                break;
            case "F":
                Console.WriteLine("GPA point: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
                    }
    }
}
