using Microsoft.AspNetCore.Identity;

namespace DataLayer.Data_table
{
    public class LpDetails:IdentityUser
    {
        public string Name { get; set; }
        public string C_Address { get; set; }
        public string Contact_person_name { get; set; }
        public string Mobile_no { get; set; }
        public string B_Address { get; set; }
        public string Account_no { get; set; }
        public string Ifsc_code { get; set; }
        public string Bank_name{ get; set; }
        public string benifesory_name { get; set; }
        public string pan { get; set; }
        public string gst { get; set; }

    }
}
