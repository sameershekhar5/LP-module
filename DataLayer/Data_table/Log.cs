using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Data_table
{
   public class Log
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public string MessageTeplate { get; set; }
        public string Level { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Exception { get; set; }
        public string LogEvent { get; set; }
    }
}
