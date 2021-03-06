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
namespace IS24RestApi.Offer.Realtor
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para xml:lang="de-DE">Ein Anbieter von IS24.</para>
    /// <para xml:lang="en">A realtor within IS24.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.4.5478.22120")]
    [System.Xml.Serialization.XmlTypeAttribute("Realtor", Namespace="http://rest.immobilienscout24.de/schema/offer/realtor/1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("realtor", Namespace="http://rest.immobilienscout24.de/schema/offer/realtor/1.0")]
    public partial class Realtor
    {
        
        /// <summary>
        /// <para xml:lang="de-DE">Die Kundennummer des Anbieters wenn er ein Kunde ist.</para>
        /// <para xml:lang="en">The customer number of the realtor if he is a customer.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("customerNumber", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string CustomerNumber 
        {
            get; set;
        }
        
        /// <summary>
        /// <para xml:lang="de-DE">Ist Firmenprofil / Homepage aktiviert.</para>
        /// <para xml:lang="en">Is the homepage activated.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("businessCardActivated", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="boolean")]
        public bool BusinessCardActivated 
        {
            get; set;
        }
    }
}
