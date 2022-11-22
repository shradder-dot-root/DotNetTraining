using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class MCAStudent : Student
    {
        static Dictionary<string, int> Stud_marks = new Dictionary<string, int>();
        Student s = new Student();
        int subs;
        int total_sub;
      
        public  void Marks()
        {

            Console.WriteLine("Enter number of Subjects :");
            subs = Convert.ToInt32(Console.ReadLine());
             total_sub = subs;
            for (int i = 0; i < subs; i++)
            {
                Console.WriteLine("Enter the Subject Name : ");
                string subject_name = Console.ReadLine();
                Console.WriteLine("Enter the Subject Marks : ");
                int marks = Convert.ToInt32(Console.ReadLine());
                Stud_marks.Add(subject_name, marks);
            }
            foreach (KeyValuePair<string, int> smarks in Stud_marks)
            {
                Console.WriteLine("Subject : {0}, Marks: {1}", smarks.Key, smarks.Value);

            }
            


        }
        public override void result_cal()
        {
            int total_marks = Stud_marks.Values.Sum();
            Console.WriteLine("Total Marks of All MCA subjects " + total_marks);
            float percentage = total_marks /total_sub;
            Console.WriteLine("Total Percentage is " + percentage + "%");
        }

    }
}

