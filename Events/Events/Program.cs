using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    //public delegate void EventHandler(string name, int cash);
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Students> university = new List<Students>();
            //Students students = new Students();
            university.Add(new Students(1, "Jonas", 36, 4.5, false));
            university.Add(new Students(2, "Kazys", 54, 3.3, false));
            university.Add(new Students(3, "Jurgis", 43, 2.4, false));
            university.Add(new Students(4, "Albinas", 56, 5.0, true));
            university.Add(new Students(5, "Darius", 27, 4.9, false));
            university.Add(new Students(6, "Juozapas", 24, 2.8, false));
            university.Add(new Students(7, "Antanina", 38, 4.6, false));

            university.ForEach(Console.WriteLine);

            List<Students> canDrink = university.FindAll(student => student.age > 32 );

            canDrink.ForEach(student => Console.WriteLine(student.name + " " + student.age));

            university.FindAll(s => s.avarageMark > 3).ForEach(s => Console.WriteLine(s.name));

            university.FindAll(stud => stud.avarageMark < 4 && stud.name.Length <=6)
                .ForEach(s => Console.WriteLine(s.name));

            Console.ReadKey();
        }
    }
}
