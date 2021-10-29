using System;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Datalayer.Data_table
{
    public partial class Services
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Recordtime { get; set; }

    }
}
