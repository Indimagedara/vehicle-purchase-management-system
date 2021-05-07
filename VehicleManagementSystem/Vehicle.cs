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
    
    public partial class Vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicle()
        {
            this.Jobs = new HashSet<Job>();
        }
    
        public long VehicleId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public long TypeId { get; set; }
        public long CategoryId { get; set; }
        public string RegNum { get; set; }
        public Nullable<int> RegYear { get; set; }
        public string Transmission { get; set; }
        public string Condition { get; set; }
        public string EngineNumber { get; set; }
        public string ChassieNumber { get; set; }
        public int Milage { get; set; }
        public double EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public string PartInventory { get; set; }
        public string Note { get; set; }
        public System.DateTime DateCreated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
