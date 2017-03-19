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
    
    public partial class VoucherAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VoucherAddress()
        {
            this.VoucherAddressChannel = new ObservableListSource<VoucherAddressChannel>();
            this.VoucherAddressClientNo = new ObservableListSource<VoucherAddressClientNo>();
        }
    
        public int Id { get; set; }
        public int SrcAvatarId { get; set; }
        public int TypeId { get; set; }
        public Nullable<int> PartnerId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> ContactId { get; set; }
        public string Name { get; set; }
        public string CountryId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Zip { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string GLN { get; set; }
        public string District { get; set; }
        public string PublicPlaceName { get; set; }
        public string PublicPlaceKind { get; set; }
        public string PublicPlaceNumber { get; set; }
        public string Building { get; set; }
        public string StairWay { get; set; }
        public string Storey { get; set; }
        public string DoorNumber { get; set; }
    
        public virtual Contact Contact1 { get; set; }
        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<VoucherAddressChannel> VoucherAddressChannel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<VoucherAddressClientNo> VoucherAddressClientNo { get; set; }
    }
}
