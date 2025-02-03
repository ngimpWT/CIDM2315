namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pleae input a grade letter."); //Part 1 Homework
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
        //Beginning of Part 2 Homework
        Console.WriteLine("Please input the first num:"); 
        int intOne = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second num:");
        int intTwo = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third num:");
        int intThree = Convert.ToInt16(Console.ReadLine());
        if(intOne<intTwo && intOne<intThree){
            Console.WriteLine($"The smallest number is: {intOne}");
        }else if(intTwo<intOne && intTwo<intThree){
            Console.WriteLine($"The smallest number is: {intTwo}");
        }else if(intThree<intOne && intThree<intTwo){
            Console.WriteLine($"The smallest number is: {intThree}");
        }else{
            Console.WriteLine("Invalid input.");
        }
    }
}
