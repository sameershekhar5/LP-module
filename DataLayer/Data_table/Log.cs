using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data_table
{
    class Log
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string MessageTeplate { get; set; }
        public string Level { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Exception { get; set; }
        public string LogEvent { get; set; }
    }
}
