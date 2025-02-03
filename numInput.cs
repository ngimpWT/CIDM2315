namespace numInput;

class Program
{
    static void Main(string[] args)
    {
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
