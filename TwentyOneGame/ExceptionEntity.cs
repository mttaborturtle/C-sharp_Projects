using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class ExceptionEntity
    {
        public int Id { get; set; }
        public String ExceptionType { get; set; }
        public String ExceptionMessage { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
