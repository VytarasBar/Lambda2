using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Students
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public double avarageMark { get; set; }
        public bool isGettingTuition { get; set; }

        List<string> students = new List<string>();

        public Students(int id, string name, int age, double avarageMark, bool isGettingTuition)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.avarageMark = avarageMark;
            this.isGettingTuition = isGettingTuition;
        }

        public override string ToString()
        {
            return $"Student {id} : {name}, {age}, mark {avarageMark}, tuitio {isGettingTuition}";
        }
    }
}
