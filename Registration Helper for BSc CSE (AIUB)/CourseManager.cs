using System;
using System.Collections.Generic;
using System.Linq;

namespace Registration_Helper_for_BSc_CSE_AIUB
{
    internal class CourseManager
    {
        private readonly BSc_in_CSE_Course_Data courseData;

        public CourseManager()
        {
            courseData = new BSc_in_CSE_Course_Data();
        }

        public void DisplayAllCourses()
        {
            Console.WriteLine("\nAll available course for BSc CSE:");
            foreach (BSc_in_CSE_Curriculum course in courseData.Course)
            {
                Console.WriteLine("Course Code       : " + course.Code);
                Console.WriteLine("Course Description: " + course.CourseDescription);
                Console.WriteLine("Prerequisite      : " + course.PreRequisite);
                Console.WriteLine("Credit            : " + course.Credit);
                Console.WriteLine();
            }
        }

        public void CourseCheckingForNextSemester()
        {
            //Check available courses based on completed courses
            Console.WriteLine("Enter last semester completed course codes separated by commas (e.g. MAT1102,PHY1101,PHY1102,ENG1101,CSC1101,CSC1103,CSC1102):");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No completed courses entered. Exiting...");
                return;
            }

            string[] completedCourseCodes = input.Split(',');

            List<BSc_in_CSE_Curriculum> availableCourses = GetAvailableCourses(completedCourseCodes);

            DisplayAvailableCourses(availableCourses);
        }

        List<BSc_in_CSE_Curriculum> GetAvailableCourses(string[] completedCourseCodes)
        {
            // Inside the GetAvailableCourses method
            List<BSc_in_CSE_Curriculum> availableCourses = new List<BSc_in_CSE_Curriculum>();

            foreach (string completedCourseCode in completedCourseCodes)
            {
                availableCourses.AddRange(courseData.Course
                    .Where(course => ArePrerequisitesMet(course, completedCourseCode) && !availableCourses.Contains(course))
                    .ToList());
            }

            return availableCourses;

        }

        public bool ArePrerequisitesMet(BSc_in_CSE_Curriculum course, string completedCourseCode)
        {
            if (string.IsNullOrEmpty(course.PreRequisite) || course.PreRequisite.Equals(BSc_in_CSE_Curriculum.Nil))
            {
                return false;
            }

            string[] prerequisites = course.PreRequisite.Split('&');

            return prerequisites.Any(prerequisite => prerequisite.Trim() == completedCourseCode);
        }

        public void DisplayAvailableCourses(List<BSc_in_CSE_Curriculum> courses)
        {
            Console.WriteLine("\nCourses available after completing the entered course(s):");
            Console.WriteLine(" CODE  " + "   " + "Course Description");
            Console.WriteLine("=======" + "= =" + "==================");
            if (courses.Count > 0)
            {
                foreach (var course in courses)
                {
                    Console.WriteLine($"{course.Code} - {course.CourseDescription}");
                }
            }
            else
            {
                Console.WriteLine("No available courses based on the completed course(s).");
            }
        }
        public void DisplayCoursesWithNoPrerequisites()
        {
            // Inside the DisplayCoursesWithNoPrerequisites method
            var coursesWithNoPrerequisites = courseData.Course.Where(c => string.IsNullOrEmpty(c.PreRequisite) || c.PreRequisite.Equals(BSc_in_CSE_Curriculum.Nil)).ToList();

            Console.WriteLine("\nCourses with no prerequisites:");
            Console.WriteLine(" CODE  " + "   " + "Course Description");
            Console.WriteLine("=======" + "= =" + "==================");
            foreach (var course in coursesWithNoPrerequisites)
            {
                Console.WriteLine($"{course.Code} - {course.CourseDescription}");
            }

        }
        public void DisplayCoursesByCredits(int credits)
        {
            var coursesWithSpecificCredits = courseData.Course.Where(c => c.Credit == credits).ToList();

            if (coursesWithSpecificCredits.Any())
            {
                Console.WriteLine($"\nCourses with {credits} credits:");
                Console.WriteLine(" CODE  " + "   " + "Course Description");
                Console.WriteLine("=======" + "= =" + "==================");
                foreach (var course in coursesWithSpecificCredits)
                {
                    Console.WriteLine($"{course.Code} - {course.CourseDescription}");
                }
            }
            else
            {
                Console.WriteLine($"No courses found with {credits} credits.");
            }
        }
    }
}
