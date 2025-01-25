/*
 Author: Victor Flores
Course:COMP-003A
Faculty: Jonathon Cruz
Purpose: Lecture Activity 3.6*/
namespace COMP003A.LectureActivity3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Advanced Control Statements Demo!");

            int range; //range of nums to iterate through
            //get range of numbers to iterate through
            while (true)
            {
                //try catch block handle invalid input
                try
                {
                    //prompt use to enter pos integer
                    Console.Write("Enter a positive integer to iterate throug: ");
                    //parse the input to an integer
                    range = int.Parse(Console.ReadLine());
                    //check if num pos
                    if (range <= 0) throw new Exception("Number must be positive.");
                    //exit loop if input is valid
                    break;
                }
                catch (Exception ex)
                { //display an error message and prompt use to try again
                  Console.WriteLine($"Invalid input: {ex.Message}\nPlease try again.\n");
                }
                
            }

            //get user's preference for skipping and terminating the loop
            Console.WriteLine("would you like to skip a number? (yes/no): ");
            //convert response to lowercase to make case-insensitive
            string skipRes = Console.ReadLine().ToLower();
            //initialize the skip num to 0
            int skipNum = 0;
            //check if user wants to skip num
            if (skipRes == "yes")
            {
                //prompt user to enter num to skip
                Console.Write("Enter the number to skip: ");
                //parse input to an int
                skipNum = int.Parse(Console.ReadLine());
            }
        }
    }
}
