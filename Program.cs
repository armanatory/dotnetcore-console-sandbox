using System;

namespace dotnetcore_console_sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Please insert the first number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Please insert the second number:");
            string input2 = Console.ReadLine();

            try{
                num1 = Convert.ToInt16(input1);
                num2 = Convert.ToInt16(input2);

                Console.WriteLine("The summation is: " + num1+num2);
            }
            catch(FormatException){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fromat Error!");
                Console.ResetColor();
            }
            catch{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unknown Error!");
                Console.ResetColor();
            }
            finally{
                Console.WriteLine("The program has finished.");
            }


            Console.ReadKey();
        }
    }
}
