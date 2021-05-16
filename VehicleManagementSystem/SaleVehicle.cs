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
    
    public partial class SaleVehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SaleVehicle()
        {
            this.Payments = new HashSet<Payment>();
        }
    
        public long SaleId { get; set; }
        public long VehicleId { get; set; }
        public string BuyerName { get; set; }
        public double SaleAmount { get; set; }
        public string Status { get; set; }
        public System.DateTime DateSold { get; set; }
        public string Phone { get; set; }
        public string NIC { get; set; }
        public string Address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}