using AgendaPersonala;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAgenda
{
    static class System
    {
        public static List<Person> People = new List<Person>();
        public static List<Agenda> Agendas = new List<Agenda>();
        public static List<Activity> Activities = new List<Activity>();
        public static Person CreatePerson(string fname, string lname, DateTime bdate, string email)
        {
            Person person = new Person() { FirstName = fname, LastName = lname, BirthDate = bdate, EmailAddress = email };
            People.Add(person);
            Console.WriteLine($"Person: {person.Details()} was created.");
            return person;
        }
        public static Agenda CreateAgenda(this Person person)
        {
            Agenda agenda = new Agenda() { Activities = new List<Activity>(), Owner = person };
            person.Agenda = agenda;
            Agendas.Add(agenda);
            Console.WriteLine($"Agenda was created on {person.Name()}.");
            return agenda;
        }
        public static Activity CreateActivity(this Person person, string name, string description, DateTime sdate, DateTime edate)
        {
            Activity activity = new Activity() { Name = name, Description = description, StartDate = sdate, EndDate = edate };
            activity.PeopleInvolved = new List<Person>() { person };
            if (person.Agenda == null) person.CreateAgenda();
            person.Agenda.Activities.Add(activity);
            Activities.Add(activity);
            Console.WriteLine($"Activity: {activity.Details()} was created and added on {person.Name()}'s agenda.");
            return activity;
        }
        public static Activity CreateActivity(string name, string description, DateTime sdate, DateTime edate)
        {
            Activity activity = new Activity() { Name = name, Description = description, StartDate = sdate, EndDate = edate };
            activity.PeopleInvolved = new List<Person>();
            Activities.Add(activity);
            Console.WriteLine($"Activity: {activity.Details()} was created.");
            return activity;
        }
        public static Activity AddActivity(this Person person, Activity activity)
        {
            activity.PeopleInvolved.Add(person);
            if (person.Agenda == null) person.CreateAgenda();
            person.Agenda.Activities.Add(activity);
            Console.WriteLine($"Activity: {activity.Details()} was added on {person.Name()}'s agenda.");
            return activity;
        }
        public static List<Activity> FindActivitiesByNameGlobal(string name)
        {
            name.ToLower().Trim();
            List<Activity> result = Activities.Where(a => a.Name.ToLower().Contains(name)).ToList();
            return result;
        }
        public static List<Activity> FindActivitiesByName(this Person person, string name)
        {
            name.ToLower().Trim();
            if (person.Agenda == null) return new List<Activity>();
            List<Activity> result = person.Agenda.Activities.Where(a => a.Name.ToLower().Contains(name)).ToList();
            return result;
        }
    }
}
