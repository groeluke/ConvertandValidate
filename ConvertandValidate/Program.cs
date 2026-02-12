/*Luke Groesbeck
Spring 2026
RCET 2265
Project CovertandValidate
Computer Fundamentals and Introduction to Programming
https://github.com/groeluke/ConvertandValidate.git
*/

/*
 [x] Take two arguments: a string value to be converted, and an out integer variable to store the result.
 [x] Return a boolean indicating if the conversion was successful.
 [x] If successful, update the out integer variable with the converted value.
 [x] If not, do not update the integer variable.
 */

namespace ConvertandValidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter an integer value or type (Q) to exit: ");
                string answer = Console.ReadLine();

                // if q is entered, the program will end
                if (answer == "Q" || answer == "q")
                {
                    break;
                }
                // if the answer is not q, the program will try to convert the answer to an integer and display the result if true
                if (ConvertToInt(answer, out int number))
                {
                    Console.WriteLine($"{answer} is a valid integer value");
                }
                // else, the program will display an error message if the answer is not a valid integer value
                else
                {
                    Console.WriteLine($"{answer} is not a valid integer value.");
                }

                Console.WriteLine("Press Enter to try again.");
                Console.ReadLine();
                Console.Clear(); // clear the console for the next input

            } while (true); // loop until the user decides to exit

            Console.WriteLine("Press Enter to close.");
            Console.ReadLine();
        }

        // method that takes a string input and an out integer variable, tries to convert the string to an integer and returns if the conversion was successful
        static bool ConvertToInt(string input, out int result)
        {
            result = 0;
            // try to convert the input string to an integer
            try 
            {
                result = int.Parse(input);
                return true;
            }
            // catch the exception if the input string is not valid and return false
            catch (FormatException) 
            {
                return false;
            }
            
        }
    }
}