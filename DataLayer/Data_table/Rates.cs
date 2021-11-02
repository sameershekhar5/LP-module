using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data_table
{
   public class Rates
    {
        public int Id { get; set; }
        public int Lpid { get; set; }
        public int Lpserviceid { get; set; }
        public int Zoneidfrom { get; set; }
        public int Zoneidto { get; set; }
        public decimal Lprates { get; set; }
        public bool Applyst { get; set; }
        public bool Applyfsc { get; set; }
        public decimal Weight { get; set; }
        public decimal Weightto { get; set; }
        public string packettype { get; set; }
        public DateTime Fromtime { get; set; }
        public DateTime Totime { get; set; }
        public string hint { get; set; }
        
    }
}
