using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //A variable that will contain a random number that the user will have to guess
            var ranNum = new Random().Next(0, 100);

            //a variable to check whether the input is an integar
            //then the user input is parsed as the guess variable
            //the default is a negative int so that we can run the while loop
            var guess = -1;

            //Welcome message for user
            Console.WriteLine("Welcome to number Guesser");
            Console.WriteLine("Try to guess a number i am thinking of between 0 and 100");

            while (guess != ranNum)
            {
                //User input
                var input = Console.ReadLine();

                //Parses the input as an in and to verify that the input is a valid int
                if (int.TryParse(input, out guess))
                {
                    //if the user guessed the correct number we display a message and break the loop
                    if(guess == ranNum)
                    {
                        Console.WriteLine("WELL DONE ! !  You got the correct number");
                        break;
                    }
                    else
                    {
                        //we display this message if the user guessed higher or lower
                        //untl they get the correct value
                        Console.WriteLine($"Not quite, think of a {(guess > ranNum? "lower": "higher")} number");
                    }
                }
                else
                {
                    Console.WriteLine("The value you guessed is not numeric");
                    continue;
                }

                Console.WriteLine("THANK YOU FOR PLAYING");
            }
        }

       
    }
}
