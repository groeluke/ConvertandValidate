/*Luke Groesbeck
Spring 2026
RCET 2265
Project MultiplicationTable
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
              string answer;
              
              do
              {
                  Console.Write("\nEnter a integer value or type (Q) to exit: ");
                  answer = Console.ReadLine();

                  if (answer == "Q" || answer == "q") // exit console if q is entered
                  {
                      break;
                  }

                if (int.TryParse(answer, out int userInput)) 
                {
                    Console.WriteLine("Good! The number is: " + userInput);
                    Console.WriteLine("Hit enter to try another.");
                }
                else //
                {
                    Console.WriteLine("Sorry, '" + answer + "' is not a valid integer value.");
                }
                Console.ReadLine();
                Console.Clear();
              } while (true);

              Console.WriteLine("Press enter to close.");

              // pause 
              Console.Read();
          }
      }
  }
