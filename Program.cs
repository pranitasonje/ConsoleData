using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathlibrary;

namespace ConsoleData
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClassMath classMath = new ClassMath();

            int addRes = classMath.AddNum(40, 55, 32);
            Console.WriteLine("Addition result is:" + addRes);

            int subRes = classMath.SubNum(70, 30);
            Console.WriteLine("Subtraction result is:" + subRes);

            long mulRes = classMath.MulNum(70, 30);
            Console.WriteLine("Multiplication result is:" + mulRes);

            int divRes = classMath.DivNum(60, 30);
            Console.WriteLine("Division result is:" + divRes);

            Console.ReadLine();
            //Student student = new Student();

            //student.StudentId = 102;
            //student.StudentName = "ankita";

            //int res = student.AddMarks(95, 90);

            //Console.WriteLine("Total Marks :" + res);
        }
    }
}
