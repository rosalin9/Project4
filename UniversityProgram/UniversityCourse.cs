using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProgram
{
    public class UniversityCourse
    {
        public int CourseCode;
        public string CourseName;
        public string InstName;
        public List<string> Students = new List<string>();

        public UniversityCourse(int courseCode, string courseName, string instName, List<string> students)
        {
            this.CourseCode = courseCode;
            this.CourseName = courseName;
            this.InstName = instName;
            this.Students = students;
        }

    }
    
}
