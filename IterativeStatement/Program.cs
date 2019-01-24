//Author: Yanjun Yang
// Date: 1/21/2019
// Comments: This deliverable demostrates the use of iterative statement after getting input from users.
using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Enter an integer value between 1 and 100.");

            // Use try catch block to validate user input.
            try
            {
                // This variable will gather data from user input.
                string input = Console.ReadLine();

                // This variable is used to perform iterative statements.
                int value_entered = int.Parse(input);

                //This if statement is used to test the values of user input.
                //Depending on the value of the user input between 1 and 100, different message will shown.
                if ((value_entered > 0) && (value_entered <= 100))
                {
                    //Here is the For loop
                    for(int i = 1; i <= value_entered; i++)
                    {
                        for (int o = 1; o <= value_entered; value_entered--)
                        {
                            Console.WriteLine("You have entered" + " " + value_entered.ToString() + ".This is the current integer value in the loop: " + i.ToString()+".");
                        }
                    }// end of for loop

                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);

                }// end of if 
                else
                {
                    Console.WriteLine("Please enter an integer value between 1 and 100.");
                }// end of else
                   
            }// end of try
            catch
            {
                Console.WriteLine("Please enter an integer.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey(true);
            }// end of catch
        }// end of main
    }// end of class
}// end of namespace
