using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.Data_table
{
    public class LpDetails:IdentityUser
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact_person_name { get; set; }
        public int MyProperty { get; set; }
    }
}
