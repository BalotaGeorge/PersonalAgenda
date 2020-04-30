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
            Person george = System.CreatePerson("Balota", "George", 
                new DateTime(2000, 5, 23), 
                "george.balota@yahoo.com");
            Activity work =  george.CreateActivity("Daily Work", "Some stuff", 
                DateTime.Now, 
                DateTime.Now.AddHours(1));
            Activity morework = System.CreateActivity("Work", 
                "Some more stuff", 
                DateTime.Now, 
                DateTime.Now.AddHours(2));
            Console.WriteLine();

            Person mark = System.CreatePerson("Gobu", "Mark", 
                new DateTime(1990, 2, 10), 
                "mark.gobu@gmail.com");
            mark.AddActivity(work);
            mark.AddActivity(morework);
            Console.WriteLine();

            List<Activity> allactivities = george.FindActivitiesByName("work");

            mark.FindActivitiesByInterval(new DateTime(2020, 4, 23), new DateTime(2020, 4, 24));
            Console.WriteLine();

            System.DeleteActivity(work);
            Console.WriteLine();

            System.FindMeetingWithGroup(2, george, mark);

            Console.ReadLine();
        }
    }
}
