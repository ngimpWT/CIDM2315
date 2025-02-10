namespace Homework3;

class Program
{
    static void Main(string[] args)
     {   
       //Problem #1----------------
        Console.WriteLine("Input an integer:");
        int i = Convert.ToInt16(Console.ReadLine());
        if(i <= 1)
            Console.WriteLine($"{i} is non-prime.");
        for (int x = i - 1; x > 0; x--)
        {
            if(x == 1)
            {
                Console.WriteLine($"{i} is prime.");
                break;
            }
            else if(i % x == 0)
            {
               Console.WriteLine($"{i} is non-prime.");
               break;
            }
        }
        //Problem #2----------------
        Console.WriteLine("Assign an int value to N:");
        int n = Convert.ToInt16(Console.ReadLine());
        for (int y = n; y > 0; y--)
        {
            for (int z = n; z > 0; z--)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }
        //Problem #3----------------
        Console.WriteLine("Assign an int value to N:");
        int a = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row < a; row++)
        {
            for(int col = 0; col < a; col++)
            {
                if(col <= row)
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        //Bonus Problem----------------
        Console.WriteLine("Assign an int value to N:");
        int b = Convert.ToInt16(Console.ReadLine());
        for(int row1 = 0; row1 < b; row1++)
        {
            for(int space = b - row1 - 1;space > 0; space--)
            {
                Console.Write(" ");
            }
            for(int col1 = 0; col1 < b; col1++)
            {
                if(col1 <= row1)
                    Console.Write(row1+1);
            }
            Console.WriteLine("");
        }
     }
} 
