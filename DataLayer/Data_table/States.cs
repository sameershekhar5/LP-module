using System;
using System.ComponentModel.DataAnnotations;
namespace DataLayer.Data_table
{
    public partial class States
    {
        [Key]
        public int Id { get; set; }
        public string Statename { get; set; }
        public DateTime recordtime { get; set; }
    }
}
