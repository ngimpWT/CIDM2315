namespace Homework5;

class Program
{
    static void Main(string[] args)
    {   
        // Main code for Q1
        Console.WriteLine("Enter two integers:");
        int first = Convert.ToInt16(Console.ReadLine());
        int second = Convert.ToInt16(Console.ReadLine());
        int result = BiggestNumber(first, second);
        Console.WriteLine($"The largest int is: {result}");

        // Main code for Q2
        Console.WriteLine("Enter four integers:");
        first = Convert.ToInt16(Console.ReadLine());
        second = Convert.ToInt16(Console.ReadLine());
        int third = Convert.ToInt16(Console.ReadLine());
        int fourth = Convert.ToInt16(Console.ReadLine());
        int AB = BiggestNumber(first, second);
        int CD = BiggestNumber(third, fourth);
        int ABCD = BiggestNumber(AB, CD);
        Console.WriteLine($"The largest int is: {ABCD}");
        
        // Main code for Q3
        CreateAccount();

    }
    //Problem 1 and 2 Method
    static int BiggestNumber(int x, int y)
    {
        if(x>y)
        return x;
        else
        return y;
    }
   //Problem 3 Methods
   static void CreateAccount() //prompts for username, password, DOB
   {
        while(true){
            Console.WriteLine("Enter Your Username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Your Password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Your Password Again:");
            string passwordCheck = Console.ReadLine();
            Console.WriteLine("Enter Your Birth Year.");
            int age = Convert.ToInt16(Console.ReadLine());
            bool ageBool = CheckAge(age);
            if(ageBool == true)
            {
                if(password== passwordCheck)
                {
                    Console.WriteLine("Account is created successfully");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account.");
            }
        }
   }
   static bool CheckAge(int birthYear) //Checks if birth year is >= 18
   {
        if(2025 - birthYear >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
   }
}
