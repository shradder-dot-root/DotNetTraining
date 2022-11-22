using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class Program
    {
        static Dictionary<string,int> dict = new Dictionary<string, int>();

        static void Main(string[] args)
        {

            Student s = new Student();
            MCAStudent m = new MCAStudent();
            BSCStudent b = new BSCStudent();


            Console.WriteLine("---------------------BSC----------------------");

            b.StudInfo();
            b.Marks();
            s.result_cal();
            b.result_cal();

            Console.WriteLine("---------------------MCA----------------------");
            m.StudInfo();
            m.Marks();
            s.result_cal();
            m.result_cal();





        }
    }
}
