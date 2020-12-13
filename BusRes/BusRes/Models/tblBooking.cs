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

    public partial class tblBooking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBooking()
        {
            this.tblCancellations = new HashSet<tblCancellation>();
            this.tblFeedbacks = new HashSet<tblFeedback>();
            this.tblReturnTickets = new HashSet<tblReturnTicket>();
        }
        [DataMember]
        public string Source_B { get; set; }
        [DataMember]
        public string Destination_B { get; set; }
        [DataMember]
        public string StartDate { get; set; }
        [DataMember]
        public string StartTime { get; set; }
        [DataMember]
        public string TicketType { get; set; }
        [DataMember]
        public float TravelFare { get; set; }
        [DataMember]
        public string CustUsername { get; set; }
        [DataMember]
        public string EmailId { get; set; }
        [DataMember]
        public string BusNo { get; set; }
        [DataMember]
        public string SelectedSeats { get; set; }
        [DataMember]
        public string paymentBy { get; set; }
        [DataMember]
        public int bookingID { get; set; }
        [DataMember]
        public string paymentId { get; set; }
        [DataMember]
        public string CancellationBit { get; set; }

        public virtual tblBu tblBu { get; set; }
        public virtual tblCustomer tblCustomer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCancellation> tblCancellations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFeedback> tblFeedbacks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReturnTicket> tblReturnTickets { get; set; }
    }
}




