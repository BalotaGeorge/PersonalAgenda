using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala
{
    public class Activity
    {
        public string Name;
        public string Description;
        public DateTime StartDate;
        public DateTime EndDate;
        public List<Person> PeopleInvolved;
        public string Details()
        {
            return $"{Name}, {Description}, {StartDate.ToShortDateString()}, {EndDate.ToShortDateString()}";
        }
    }
}
