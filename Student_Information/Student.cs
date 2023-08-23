using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information
{
    public class Student
    {
        public int Id;
        public string Name;
        public int Age;
        public int[] marks = new int[5];
        public int total;

      
    }
    public class ListOfStudents
    {
        List<Student> student = new List<Student>();
        int max_student;

        public void AddRecord()
        {
            Student stud = new Student();
            Console.Write("Enter student ID: ");
            stud.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter student Name: ");
            stud.Name = Console.ReadLine();
            Console.Write("Enter student age: ");
            stud.Age = Convert.ToInt32(Console.ReadLine());
            stud.total = 0;
            Console.WriteLine("Enter the marks in 5 subjects: ");
            for(int i = 0; i < 5; i++) 
            {
                stud.marks[i] = Convert.ToInt32(Console.ReadLine());
                stud.total += stud.marks[i];
            }
            student.Add(stud);
            max_student = student.Count;
        }

        
        public void ViewRecord()
        {
            int maxVal = student[0].total;
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("ID     Student Name      Age     Sub1   Sub2    Sub3   Sub4   Sub5   Total");
            Console.WriteLine("-----------------------------------------------------------------------------");
            for (int i = 0;i < max_student;i++) 
            {
                Console.Write("{0,-5}",student[i].Id);
                Console.Write("{0,-19}", student[i].Name);
                Console.Write("{0,-7}", student[i].Age);
                Console.Write("{0,-7}", student[i].marks[0]);
                Console.Write("{0,-7}", student[i].marks[1]);
                Console.Write("{0,-7}", student[i].marks[2]);
                Console.Write("{0,-7}", student[i].marks[3]);
                Console.Write("{0,-7}", student[i].marks[4]);
                Console.Write("{0,-7}", student[i].total);
                Console.WriteLine();
                if (maxVal < student[i].total)
                    maxVal= student[i].total;
            }
            Console.WriteLine("-----------------------------------------------------------------------------");

            for(int i=0; i< max_student; i++)
            {

                if (student[i].total == maxVal)
                {
                    Console.WriteLine("Name of the student who secured the Highest Mark");
                    Console.Write("{0,-5}",student[i].Id);
                    Console.Write("{0,-19}", student[i].Name);
                    Console.Write("{0,-7}", student[i].Age);
                    Console.Write("{0,-7}", student[i].total);
                }
            }

        }
        
    }

}
