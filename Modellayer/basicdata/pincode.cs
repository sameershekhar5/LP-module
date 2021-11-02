using System;
using System.ComponentModel.DataAnnotations;

namespace Modellayer.basicdata
{
    public class pincode
    {
        [Key]
        public int Id { get; set; }
        public int Pincode { get; set; }
        public int stateid { get; set; }
        public DateTime entrydate { get; set; }
    }
}
