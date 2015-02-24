//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.34014
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 0.4.5478.22120.
namespace IS24RestApi.Offer.RealEstateStock
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.4.5478.22120")]
    [System.Xml.Serialization.XmlTypeAttribute("realEstateStock", Namespace="http://rest.immobilienscout24.de/schema/offer/realestatestock/1.0", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("realEstateStock", Namespace="http://rest.immobilienscout24.de/schema/offer/realestatestock/1.0")]
    public partial class RealEstateStock
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("priceRegionRealEstateStock", Namespace="http://rest.immobilienscout24.de/schema/offer/realestatestock/1.0")]
        public System.Collections.ObjectModel.Collection<PriceRegionRealEstateStock> PriceRegionRealEstateStock 
        {
            get; private set;
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="RealEstateStock" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="RealEstateStock" /> class.</para>
        /// </summary>
        public RealEstateStock()
        {
            this.PriceRegionRealEstateStock = new System.Collections.ObjectModel.Collection<PriceRegionRealEstateStock>();
        }
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.4.5478.22120")]
    [System.Xml.Serialization.XmlTypeAttribute("priceRegionRealEstateStock", Namespace="http://rest.immobilienscout24.de/schema/offer/realestatestock/1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("priceRegionRealEstateStock", Namespace="http://rest.immobilienscout24.de/schema/offer/realestatestock/1.0")]
    public partial class PriceRegionRealEstateStock
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("priceRegion", Namespace="http://rest.immobilienscout24.de/schema/offer/realestatestock/1.0")]
        public PriceRegion PriceRegion 
        {
            get; set;
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private int _realestateCount = 0;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("realestateCount", Namespace="http://rest.immobilienscout24.de/schema/offer/realestatestock/1.0", DataType="int")]
        public int RealestateCount 
        {
            get 
            {
                return this._realestateCount;
            }
            set 
            {
                this._realestateCount = value;
            }
        }
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.4.5478.22120")]
    [System.Xml.Serialization.XmlTypeAttribute("priceRegion", Namespace="http://rest.immobilienscout24.de/schema/offer/realestatestock/1.0")]
    public enum PriceRegion
    {
        
        /// <summary>
        /// </summary>
        A,
        
        /// <summary>
        /// </summary>
        B,
        
        /// <summary>
        /// </summary>
        C,
        
        /// <summary>
        /// </summary>
        D,
        
        /// <summary>
        /// </summary>
        E,
    }
}
