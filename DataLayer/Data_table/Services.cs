using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Data_table
{
    public partial class Services
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
