//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusRes.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class tblCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCustomer()
        {
            this.tblBookings = new HashSet<tblBooking>();
        }

        [DataMember]

        public int Index_ { get; set; }
        [DataMember]
        public string username { get; set; }
        [DataMember]
        public string Fname { get; set; }
        [DataMember]
        public string Lname { get; set; }
        [DataMember]
        public string Password_ { get; set; }
        [DataMember]
        public string EmailId { get; set; }
        [DataMember]
        public string ContactNo { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DOB { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public Nullable<float> WalletDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBooking> tblBookings { get; set; }
    }
}
