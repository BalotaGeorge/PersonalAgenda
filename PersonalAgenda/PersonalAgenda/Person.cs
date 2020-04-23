using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaPersonala
{
    public class Person
    {
        public string LastName;
        public string FirstName;
        public DateTime BirthDate;
        public string EmailAddress;
        public Agenda Agenda;
        public string Name()
        {
            return $"{LastName} {FirstName}";
        }
        public string Details()
        {
            return $"{Name()}, {BirthDate.ToShortDateString()}, {EmailAddress}";
        }
    }
}
