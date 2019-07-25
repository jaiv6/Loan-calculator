using System;


namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();

            while (true)
            {

                //generate a random correct number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //initialize the guess
                int guess = 0;

                //tell the user to enter a number
                Console.WriteLine("Please enter a number between 0 and 10");



                //now guess furthermore
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //validate the input as if it is not a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Blue, "Enter a number");

                        continue;
                    }


                    //change input to an integer
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        //tell to enter again
                        PrintColorMessage(ConsoleColor.Red, "Guess again");
                    }

                }


                //if guess is 7
                PrintColorMessage(ConsoleColor.Yellow, "you guessed correctly!");
                



                //do you want to play again?
                Console.WriteLine("Do you want to play again? [Y or N]");

                //make the input to upper case
                string descision = Console.ReadLine().ToUpper();

                //check if yes or no
                if(descision == "Y")
                {
                    continue;
                }
                else if(descision == "N"){
                    return;
                }
                /*else
                {
                    return;
                }*/
            }
            
        }




        static void Greeting()
        {
            //get user inputs
            string name = Console.ReadLine();

            //change color
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Hi {0}, Let's play a game", name);
            PrintColorMessage(ConsoleColor.Green, "Hi "+name+", Let's play a game");
        }



        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
