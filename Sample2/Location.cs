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
    
    public partial class Location
    {
        public int LocationId { get; set; }
        public string RackName { get; set; }
        public string LocationCode { get; set; }
        public int RowNo { get; set; }
        public int ColumnNo { get; set; }
        public string LocationType { get; set; }
        public string ZoneType { get; set; }
        public string Bin { get; set; }
        public int IsUsed { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string RecordStatus { get; set; }
    }
}
