using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleData
{
    public class Student
    {
        
        public int StudentId;

        public string StudentName;

        public Student()
        {
            StudentId = 0;

            StudentName = "Pranita";
        }

        public int AddMarks(int mark1, int mark2)
        {
            int result = mark1 + mark2;
            return result;
        }
    }
}

