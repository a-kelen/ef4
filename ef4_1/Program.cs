using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ef4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Db db = new Db())
            {
                var res =  db.Students.Select(x => new {
                    Student = x,
                    Courses = x.Courses.Select(t => t.Course)
                }).ToList();
                foreach(var a in res)
                {
                    WriteLine(new string('-', 70));
                    WriteLine($" Name : {a.Student.Name} \t | {a.Student.Birthday.ToShortDateString()}");
                    WriteLine(new string('-', 50));
                    foreach(var b in a.Courses)
                    {
                        WriteLine($"\t { b.Id}) Name : {b.Name}  - price = {b.Price} ");
                    }
                    WriteLine(new string('-', 50));
                    WriteLine();

                }
            }

            ReadKey();
        }
    }
}
