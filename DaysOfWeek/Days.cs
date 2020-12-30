using System;
using System.Collections.Generic;
using System.Text;

namespace DaysOfWeek
{
    public class Days
    {
        public Day Day { get; set; }
    }
    
    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
