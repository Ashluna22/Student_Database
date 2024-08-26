using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays needed
            //studentName
            //studentHome
            //faveFood

            string[] studentNames = { "Alice", "Bob", "Charlie" };
            string[] homeTowns = { "Seattle", "New York", "Los Angeles" };
            string[] favoriteFoods = { "Pizza", "Sushi", "Burgers" };

            bool continueQuerying = true;

            while (continueQuerying)
            {
                Console.Write("Enter a student number (1 to 3): ");
                int studentNumber;

                if (int.TryParse(Console.ReadLine(), out studentNumber))
                {
                    if (studentNumber >= 1 && studentNumber <= studentNames.Length)
                    {
                        // Display student name
                        string studentName = studentNames[studentNumber - 1];
                        Console.WriteLine($"Student {studentNumber}: {studentName}");

                        Console.WriteLine("What would you like to know about the student? Enter 'hometown' or 'favorite food': ");
                        string category = Console.ReadLine().Trim().ToLower();

                        if (category == "hometown")
                        {
                            Console.WriteLine($"Hometown: {homeTowns[studentNumber - 1]}");
                        }
                        else if (category == "favorite food")
                        {
                            Console.WriteLine($"Favorite food: {favoriteFoods[studentNumber - 1]}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid category. Please enter 'hometown' or 'favorite food'.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid student number. Please enter a number between 1 and 3.");
                    }

                    Console.Write("Would you like to learn about another student? (yes/no): ");
                    string anotherStudent = Console.ReadLine().Trim().ToLower();

                    if (anotherStudent != "yes")
                    {
                        continueQuerying = false;
                        Console.WriteLine("Thank you for using the student information system!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid student number.");
                }
            }
        }

    }
}



















