using System;

public class RockPaperScissors
{
    public static void Main()
    {
        HumanPlayer human = new HumanPlayer(5); //Instantiates Human Object
        ComputerPlayer robot = new ComputerPlayer(); //Instantiates Comnputer Object
        int x = human.GetPoints();

        while (human.GetPoints() > 0)
        {
            Console.WriteLine("****Rock Paper Scissors, Start!!****");
            Console.WriteLine($"You have {human.GetPoints()} points.");
            Console.WriteLine("Please input your choice: Rock, Paper, or Scissors.");

            string userInput= Console.ReadLine();
            userInput = human.HumanDecision(userInput);
            string robotDecision = robot.ComputerDecision();

            Console.WriteLine($"Your decision: {userInput}");
            Console.WriteLine($"Computer decision: {robotDecision}");

            switch (userInput)
            {
                case "rock":
                    if (robotDecision == "paper")
                    {
                        human.LoseRound();
                        Console.WriteLine("You lose!");
                    }
                    else if (robotDecision == "scissors")
                    {
                        human.WinRound();
                        Console.WriteLine("You win!");
                    }
                    else
                        Console.WriteLine("It's a tie!");
                    break;
                case "paper":
                    if (robotDecision == "scissors")
                    {
                        human.LoseRound();
                        Console.WriteLine("You lose!");
                    }
                    else if (robotDecision == "rock")
                    {
                        human.WinRound();
                        Console.WriteLine("You win!");
                    }
                    else
                        Console.WriteLine("It's a tie!");
                    break;
                case "scissors":
                    if (robotDecision == "rock")
                    {
                        human.LoseRound();
                        Console.WriteLine("You lose!");
                    }
                    else if (robotDecision == "paper")
                    {
                        human.WinRound();
                        Console.WriteLine("You win!");
                    }
                    else
                        Console.WriteLine("It's a tie!");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            //Asks user if they want to play again
            Console.WriteLine("Play again? Input y to continue, or n to exit.");
            string playAgain = Console.ReadLine();

            if (playAgain == "y")
            {
                continue;
            }
            else if (playAgain == "n")
                break;
            else
                Console.WriteLine("Invalid Input");

            continue;
        }
        //After loop breaks
        if (human.GetPoints() <= 0)
        {
            Console.WriteLine("Sorry, you don't have enough points.");
        }

        Console.WriteLine("Thanks for playing!");
    }
}

class HumanPlayer
{
    private int points; //the points that the human player has
    public HumanPlayer(int initial) //constructor used to set human player's initial points
    {
        points = initial;
    }
    public int GetPoints() //return the points of human player
    {
        return points;
    }
    public int WinRound() //human player increases 5 points
    {
        points += 5;
        return points;
    }
    public int LoseRound() //human player decreases 5 points
    {
        points -= 5;
        return points;
    }
    public string HumanDecision(string userInput) //human player selects a shape from Rock, Paper, or Scissors to compare w/ Computer's selection
    {
        return userInput.ToLower(); //reads from a ReadLine() in Main
    }
}
class ComputerPlayer
{
    public string ComputerDecision()
    {
        Random rnd = new Random();
        int rnd_num = rnd.Next(0, 3);

        //Console.WriteLine(rnd_num); //use if statement to declare 0, 1, 2 as rock, paper, scissors
        if (rnd_num == 0)
            return "rock";
        else if (rnd_num == 1)
            return "paper";
        else
            return "scissors";
    }
}
