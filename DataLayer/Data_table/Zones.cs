using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataLayer.Data_table
{
    public partial class Zones
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public int Lpid { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
