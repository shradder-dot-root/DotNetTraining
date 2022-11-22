using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class Student
    {
       public void StudInfo()
        {
            Console.WriteLine("Enter Student ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Stream Between MCA or BSC");
            string stream = Console.ReadLine();

        }
        public virtual void result_cal()
        {
            Console.WriteLine("Calculating Result Wait For Some Time....");
            Console.WriteLine("-------------------------------------------");

        }




    }
}
