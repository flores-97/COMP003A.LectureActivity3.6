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
                    Console.Write("Enter a positive integer to iterate through: ");
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

            //get user preference for terminiating loop
            Console.Write("Would you like to terminate the loop at a specific number? (yes/no): ");
            //convert response to lowercase to make case-insensitive
            string termRes = Console.ReadLine().ToLower();
            //initialize the termination number to 0
            int termNum = 0;
            //check if user wants to terminate loop
            if (termRes == "yes")
            {
                //prompt user to enter term num
                Console.Write("Enter the termination number: ");
                //parse input to integer
                termNum = int.Parse(Console.ReadLine());    
            }

            //display output
            Console.WriteLine("\nOutput:");
            //iterate through the range of nums
            for (int i =1; i <= range; i++)
            {
                //check if current num is num to skip
                if (i == skipNum)
                {
                    continue;//skip the specified num
                }

                //check if current num is num to terminate
                if (i == termNum)
                {
                    //display message and break out of loop
                    Console.WriteLine($"Loop terminated at number {termNum}.");
                    break;//terminate loop
                }
                
                //display current num
                Console.WriteLine(i);
            }

            //prompt use to restart program
            Console.Write("Enter 'restart' to try again or any other key to exit: ");
            //convert response to lowercase to make case-insensitive
            string restart = Console.ReadLine().ToLower();

            //check if user wants to restart
            if (restart == "restart")
            {
                goto restart;
            }

        //label to restart the program 
        restart:
            //display a message and restart program
            //restart program
            Main(args);//restart program
        }
    }
}
