namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
    //Problem 1 MAIN
        Console.WriteLine("Enter first integer:");
        int int1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter second integer:");
        int int2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"The largest number is: {FindLarge(int1, int2)}");
    //Problem 2 MAIN
        Console.WriteLine("Enter an integer:");
        int row = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Left or right?");
        string direction = Console.ReadLine();
        if(direction.ToLower() == "right")
            DoRight(row);
        else if(direction.ToLower() == "left")
            DoLeft(row);
        else
            Console.WriteLine("Error, please type 'right' or 'left'");
    }
    //Problem 1 Method
    static int FindLarge (int x, int y)
    {
        if(x>y)
        return x;
        else
        return y;
    }
    //Problem 2 Methods
    static void DoLeft(int a)
    {
        for(int row = 0; row < a; row++)
        {
            for(int col = 0; col < a; col++)
            {
                if(col <= row)
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
    static void DoRight(int b)
    {
        for(int row1 = 0; row1 < b; row1++)
        {
            for(int space = b - row1 - 1;space > 0; space--)
            {
                Console.Write(" ");
            }
            for(int col1 = 0; col1 < b; col1++)
            {
                if(col1 <= row1)
                    Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}
