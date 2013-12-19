//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 1.0.5101.29074.
namespace IS24RestApi.Offer.ProductBookingOverview
{
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.5101.29074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("productBookingOverview", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0", AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute("productBookingOverview", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0")]
    public partial class ProductBookingOverview
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("productBooking", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0")]
        public Collection<ProductBooking> ProductBooking { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ProductBookingOverview" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ProductBookingOverview" /> class.</para>
        /// </summary>
        public ProductBookingOverview()
        {
            this.ProductBooking = new Collection<ProductBooking>();
        }
    }
    
    /// <summary>
    /// <para>Booking with name, price and number of bookings</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.5101.29074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("productBooking", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0")]
    public partial class ProductBooking
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("name", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0", DataType="string")]
        public string Name { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("numberOfBookings", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0", DataType="long")]
        public long NumberOfBookings { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("price", Namespace="ttp://rest.immobilienscout24.de/schema/offer/productbookingoverview/1.0", DataType="decimal")]
        public decimal Price { get; set; }
    }
}
