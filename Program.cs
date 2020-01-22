using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the table of powers!");
            Console.Write("Please enter a positive integer: ");

            //Set while loop boolean
            bool runAgain = true;

            //While room to run until user wants to exit
            while (runAgain) {
                //Declare user input variable and get input from user
                string userInput = Console.ReadLine();
                //TryParse input into an int and set boolean
                bool worked = int.TryParse(userInput, out int num);
                
                //check if int was not entered
                if (!worked)
                {
                    Console.Write("That wasn't an integer! Please try again: ");
                    continue;
                }
                // check if 0 or a negative number was entered
                else if(num <=0)
                {
                    Console.Write("That is not a postive whole integer. Please try again: ");
                    continue;
                }
                // check if 1291 or greater is entered since this number cubed or higher will not fit in an int
                else if(num > 1290)
                {
                    Console.Write("That number is too large! Please try a number less than 1291: ");
                    continue;
                }
                // This should only run if an int between 1 and 1290 is entered
                else
                {
                    //Heading
                    Console.WriteLine("Number\t\tSquared\t\tCubed");
                    Console.WriteLine("======= \t======= \t=======");
                    
                    //For loop to loop through user inputted integer
                    for (int i = 1; i <= num; i++)
                    {
                        //Calculate square and double and convert to string for formatting
                        string padding = i.ToString();
                        string paddingSquare = Math.Pow(i, 2).ToString();
                        string paddingCube = Math.Pow(i, 3).ToString();

                        //Format string to be right aligned
                        Console.WriteLine($"{padding.PadLeft(7)}\t\t{paddingSquare.PadLeft(7)}\t\t{paddingCube.PadLeft(7)}");
                    }
                }

                // ask user if they want to run again
                Console.Write("Do you want to run the program again? (y/n): ");
                userInput = Console.ReadLine();

                if (userInput == "y")
                {
                    runAgain = true;
                    Console.Write("Please enter a positive integer: ");
                }
                else
                {
                    runAgain = false;
                }
            }
        }
    }
}

