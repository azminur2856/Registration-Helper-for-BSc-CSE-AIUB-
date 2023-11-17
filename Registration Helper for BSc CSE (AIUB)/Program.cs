using System;

namespace Registration_Helper_for_BSc_CSE_AIUB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Developed by AZMINUR RAHMAN\nStudent BSc CSE (AIUB)\nID: 22-46588-1\n");

            CourseManager manager = new CourseManager();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Display all courses for BSc CSE");
                Console.WriteLine("2. Check available courses based on completed courses");
                Console.WriteLine("3. Display courses with no prerequisites");
                Console.WriteLine("4. Display courses by credits");
                Console.WriteLine("5. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        manager.DisplayAllCourses();
                        break;
                    case 2:
                        manager.CourseCheckingForNextSemester();
                        break;
                    case 3:
                        manager.DisplayCoursesWithNoPrerequisites();
                        break;
                    case 4:
                        Console.WriteLine("Enter the number of credits to find courses:");
                        if (int.TryParse(Console.ReadLine(), out int creditsInput))
                        {
                            manager.DisplayCoursesByCredits(creditsInput);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option (1-5).");
                        break;
                }
            }
        }
    }
}
