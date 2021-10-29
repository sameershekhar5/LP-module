﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Datalayer.Data_table
{
    public partial class OPS_Mst_ProvisionalMerchant
    {
        [Key]
        public int ProvMerchantId { get; set; }
#nullable enable
        public string? ProvMerchantRefNo { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactPersonName { get; set; }
        public string? EmailId { get; set; }
        public string? PhoneNo { get; set; }
        public string? State { get; set; }
        public int? Pin { get; set; }
        public long? ItemNo { get; set; }
        public string? ItemEnquire { get; set; }
        public string? Remark { get; set; }
        public string? Interested { get; set; }
        public string? CretedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? Channel { get; set; }
        public string? Enquiary_Number { get; set; }
#nullable disable
    }
}
