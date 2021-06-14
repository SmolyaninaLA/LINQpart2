using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace LINQpart2
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
          {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        public static string[] GetAllStudents(Classroom[] classes)
        {
            string[] tmp = new string[9];

            var Class = classes.Select(c => c);

            int i = 0;

            foreach (var c in Class)
            {

                foreach (var s in c.Students)
                {
                    tmp[i] = s;

                    i++;
                }
            }

            var ret = tmp.OrderBy(p => p).ToArray();

            return ret;
         
        }
    }
    
}
