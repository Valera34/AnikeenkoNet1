using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnikeenkoNet1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student st2 = new Student("Sasha", new Dictionary<string, int>()
                                                            {
                                                                {"Obdz",20},
                                                                {"Math", 20},
                                                                {"Ukr",20}
                                                            });

            Student st = new Student("Max", new Dictionary<string, int>()
                                                            {
                                                                {"Obdz",75},
                                                                {"Math", 80},
                                                                {"Ukr",100}
                                                            });
            
            Student st3 = new Student("Leon", new Dictionary<string, int>()
                                                            {
                                                                {"Obdz",60},
                                                                {"Math", 50},
                                                                {"Ukr",70}
                                                            });
            
            List<Student> students = new List<Student>();
            students.Add(st);
            students.Add(st2);
            students.Add(st3);

            students.Sort((s1, s2) => s2.getAverage().CompareTo(s1.getAverage()));
            foreach (var student in students)
            {
                Console.Write(student.ToString() + " ");
            }

            Console.ReadLine();
        }
    }
}
