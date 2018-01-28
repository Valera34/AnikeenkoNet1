using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnikeenkoNet1
{
    class Student
    {
        public String name;
        public Dictionary<string, int> grades;
        public Student(string name, Dictionary<string, int> grades)
        {
            this.name = name;
            this.grades = grades;
        }

        public double getAverage()
        {
            double average = grades.Values.Average(num => Convert.ToInt64(num));
            return average;
        }

        public override string ToString()
        {
            String res = "";
            foreach (KeyValuePair<string, int> pair in grades)
            {
                
              res =res +"  "+   pair.Key.ToString() + "  -  " + pair.Value.ToString();
            };
            return base.ToString() + ": " + name.ToString() + " " + res +" "+ "Average mark: "+getAverage()+" \n";
        }
    }
}
