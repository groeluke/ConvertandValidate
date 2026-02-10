/*Luke Groesbeck
Spring 2026
RCET 2265
Project MultiplicationTable
Computer Fundamentals and Introduction to Programming

*/

/*
 [] Take two arguments: a string value to be converted, and an out integer variable to store the result.
 [] Return a boolean indicating if the conversion was successful.
 [] If successful, update the out integer variable with the converted value.
 [] If not, do not update the integer variable.
 */

  namespace ConvertandValidate
  {
      internal class Program
      {
          static bool TryConvert(string text, out int result)
          {
              result = 0;     // must assign something to out parameter

              // Try to convert - if it works we keep the number
              // if it fails we leave result as 0 and return false
              bool worked = int.TryParse(text, out result);

              return worked;
          }

          static void Main(string[] args)
          {
              string answer;

              do
              {
                  Console.Write("\nEnter a whole number (or type quit to stop): ");
                  answer = Console.ReadLine();

                  if (answer == "quit" || answer == "Quit")
                  {
                      break;
                  }

                  int userInput;
                  bool success = TryConvert(answer, out userInput);

                  if (success)
                  {
                      Console.WriteLine("Good! The number is: " + userInput);
                  }
                  else
                  {
                      Console.WriteLine("Sorry, '" + answer + "' is not a valid number.");
                  }

              } while (true);

                Console.WriteLine("Thanks for playing!");
                Console.WriteLine("Press enter to close.");
                Console.Read();
            }
        }
    }
