//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sample2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Part
    {
        public int PartsID { get; set; }
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public decimal PartUnitPrice { get; set; }
        public decimal length { get; set; }
        public decimal Breadth { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string RecordStatus { get; set; }
    }
}