using System;
using System.ComponentModel.DataAnnotations;

namespace Modellayer.basicdata
{
    public class states
    {
        [Key]
        public int Id { get; set; }
        public string Statename { get; set; }
        public string Disticname { get; set; }
        public string Regionname { get; set; }
        public DateTime recordtime { get; set; }
    }
}
