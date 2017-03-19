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
    
    public partial class OfferItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OfferItem()
        {
            this.OfferItemCollector = new ObservableListSource<OfferItemCollector>();
            this.OfferItemProperty = new ObservableListSource<OfferItemProperty>();
            this.OfferItemSchedule = new ObservableListSource<OfferItemSchedule>();
        }
    
        public int Id { get; set; }
        public int OfferVersionGroupId { get; set; }
        public int OrdinalNumber { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string ReferencePartNo { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string Measure { get; set; }
        public Nullable<decimal> BaseUnitPrice { get; set; }
        public Nullable<decimal> OffUnitPrice { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> TaxId { get; set; }
        public Nullable<decimal> BaseAmount { get; set; }
        public Nullable<decimal> OffAmount { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> BaseTax { get; set; }
        public Nullable<decimal> OffTax { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> BaseTotal { get; set; }
        public Nullable<decimal> OffTotal { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> DiscountPercent { get; set; }
        public bool IsDiscountPercent { get; set; }
        public bool IsOption { get; set; }
        public Nullable<int> DeliveryTimeValue { get; set; }
        public Nullable<int> DeliveryTimeUnit { get; set; }
        public string Note { get; set; }
        public string ClientPartNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<OfferItemCollector> OfferItemCollector { get; set; }
        public virtual OfferVersionGroup OfferVersionGroup { get; set; }
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<OfferItemProperty> OfferItemProperty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableListSource<OfferItemSchedule> OfferItemSchedule { get; set; }
    }
}
