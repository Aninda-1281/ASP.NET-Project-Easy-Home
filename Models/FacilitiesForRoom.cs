//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projectsd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FacilitiesForRoom
    {
        public int id { get; set; }
        public Nullable<int> facilitiesId { get; set; }
        public Nullable<int> RoomId { get; set; }
    
        public virtual Facility Facility { get; set; }
        public virtual Room Room { get; set; }
    }
}
