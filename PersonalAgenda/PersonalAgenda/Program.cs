using AgendaPersonala;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Person george = System.CreatePerson("George", "Balota", new DateTime(2000, 5, 23), "george.balota@yahoo.com");
            Activity work =  george.CreateActivity("Daily Work", "Some stuff", DateTime.Now, DateTime.Now);
            Activity morework = System.CreateActivity("Work", "Some more stuff", DateTime.Now, DateTime.Now);

            Person mark = System.CreatePerson("Mark", "Gobu", new DateTime(1990, 2, 10), "mark.gobu@gmail.com");
            mark.AddActivity(work);
            mark.AddActivity(morework);

            List<Activity> allactivities = george.FindActivitiesByName("work");

            Console.ReadLine();
        }
    }
}
