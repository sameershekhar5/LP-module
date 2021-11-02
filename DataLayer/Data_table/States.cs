using System;
using System.ComponentModel.DataAnnotations;
namespace DataLayer.Data_table
{
    public partial class States
    {
        [Key]
        public int Id { get; set; }
        public string Statename { get; set; }
        public string Disticname { get; set; }
        public string Regionname { get; set; }
        public DateTime recordtime { get; set; }
    }
}
