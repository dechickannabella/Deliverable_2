/* Author: AnnaBella DeChick 
 Date: 1/24/2023
 Description: C# Console Application for calculating grades 
*/

using System; 
class HelloWorld
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter your grade in ISM 4300:");
                int num = int.Parse(Console.ReadLine());

                if (num >= 1 && num < 60)
                {
                    Console.WriteLine("\nYour letter grade is F");
                }

                else if (num >= 60 && num < 70)
                {
                    Console.WriteLine("\nYour letter grade is D");
                }

                else if (num >= 70 && num < 80)
                {
                    Console.WriteLine("\nYour letter grade is C");
                }

                else if (num >= 80 && num < 90)
                {
                    Console.WriteLine("\nYour letter grade is B");
                }

                else if (num >= 90 && num <= 100)
                {
                    Console.WriteLine("\nYour letter grade is A");
                }

                else
                {
                    Console.WriteLine("\nYour grade is not valid.");

                }

            }

            catch (FormatException ex)
            {
                Console.WriteLine("Not a valid number grade. Please enter a different number.");

            }

            Console.WriteLine(" ");
        }
    }
}

