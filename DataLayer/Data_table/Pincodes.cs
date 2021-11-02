using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Data_table
{
    public class Pincodes
    {
        [Key]
        public int Id { get; set; }
        public int Pincode { get; set; }
        public int stateid { get; set; }
        public DateTime entrydate { get; set; }
    }
}
