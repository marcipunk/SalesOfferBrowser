//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesOfferBrowser
{
    using System;
    using System.Collections.Generic;
    
    public partial class OfferFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OfferFile()
        {
            this.Offer = new ObservableListSource<Offer>();
            this.OfferFileNote = new ObservableListSource<OfferFileNote>();
            this.OfferFileReport = new ObservableListSource<OfferFileReport>();
        }
    
        public int Id { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<int> AvatarId { get; set; }
        public int TaxYearId { get; set; }
        public string Name { get; set; }
        public int CurrentCounter { get; set; }
        public string VoucherSign { get; set; }
        public string NullVoucherNum { get; set; }
        public int DivisionId { get; set; }
        public bool RoundItem { get; set; }
        public bool RoundVat { get; set; }
        public bool RoundTotal { get; set; }
        public bool IsClosed { get; set; }
        public int DefaultTransactionTypeId { get; set; }
        public Nullable<int> DefaultOrderFileId { get; set; }
        public bool DisContinued { get; set; }
        public bool VoucherCopyEmailing { get; set; }
        public Nullable<int> PrepaymentFileId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<Offer> Offer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<OfferFileNote> OfferFileNote { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<OfferFileReport> OfferFileReport { get; set; }
    }
}
