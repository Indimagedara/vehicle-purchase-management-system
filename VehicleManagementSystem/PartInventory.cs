//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class PartInventory
    {
        public long InventoryId { get; set; }
        public long VehicleId { get; set; }
        public long InventoryItemId { get; set; }
        public bool ItemStatus { get; set; }
        public byte[] ItemNote { get; set; }
    }
}
