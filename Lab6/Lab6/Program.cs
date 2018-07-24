using System;

namespace Lab6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numOfSides;
            string userAnswer;

            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n)");
            // whether or not it will take it as a value. that the user input is y/n
            userAnswer = Console.ReadLine(); //takes the user input of y/n

            if (userAnswer.ToLower() == "y") //if the userAnswer.ToLower method is equal to y
            {
                do
                {
                    // prompt asking for input
                    Console.WriteLine("How many sides should each dice have?");
                    // take in the value the user input
                    numOfSides = int.Parse(Console.ReadLine());
                    // to make sure it won't break add exception if people don't put numbers
                    // dice value can only have the max number of sizes
                    Random rollDice = new Random(); // random class 
                    Console.WriteLine("Roll: ");
                    Console.WriteLine(rollDice.Next(1, numOfSides));//(min, max)
                    Console.WriteLine(rollDice.Next(1, numOfSides));

                    // validation
                    Console.WriteLine("Roll again? (y/n)");
                    userAnswer = Console.ReadLine(); 
                }

                while (userAnswer == "y");
            }
 
        }
    }
}


//one input and two outputs
