using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProgram
{
    
    public class Program
    {
        static List<UniversityCourse> Courses = new List<UniversityCourse>();


        public static void EnrollStudent()
        {
            Console.Write("Enter the course ID: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the course name: ");
            string cname = Console.ReadLine();
            Console.Write("Enter the instructor name: ");
            string iname = Console.ReadLine();
            Console.WriteLine("Enter all the students name who enrolled in {0} course: ", cname);
            List<string> sname = new List<string>();
            sname.Add(Console.ReadLine());
            string ch;
            do
            {
                Console.Write("Is this the last student? (Yes/No) : ");
                ch = Console.ReadLine();
                if (ch == "No")
                {
                    sname.Add(Console.ReadLine());

                }
            } while (ch == "No");
            Courses.Add(new UniversityCourse(Id, cname, iname, sname));
        }


        public static void DisplayStudent()
        {
            Console.WriteLine("Course ID        Course Name         Instructor Name        Students Name");
            Console.WriteLine("--------------------------------------------------------------------------");
            foreach(UniversityCourse course in Courses) 
            {
                Console.Write("{0,-20}",course.CourseCode);
                Console.Write("{0,-20}",course.CourseName);
                Console.Write("{0,-20}",course.InstName);
                foreach(string name in course.Students)
                {
                    Console.Write("{0}, ",name);
                }
                Console.WriteLine();
            }
        }
        public static void DropStudent()
        {
            Console.Write("Enter the student name who dropped: ");
            string name = Console.ReadLine();
            //Console.Write("Enter the course name from which {0} dropped: ", name);
            //string crname = Console.ReadLine();
            //UniversityCourse stuName = Courses.Students.Find(x => x.Students == name);

            foreach(UniversityCourse course in Courses)
            {
                string stuName = course.Students.Find(x => x.Equals(name));
       
                course.Students.Remove(stuName);
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our University Program!");
            Console.WriteLine();
            Console.WriteLine("1. Enroll the student");
            Console.WriteLine("2. Drop the student");
            Console.WriteLine("3. Display all the students in a course");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            int op;
            do
            {
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        EnrollStudent();

                        break;
                    case 2:
                        DropStudent();
                        break;
                    case 3:
                        DisplayStudent();
                        break;

                }
            } while (op > 0 && op < 4);



        }
    }
}
