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
namespace IS24RestApi.Realestate.Counts
{
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.5101.29074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("realEstateCounts", Namespace="http://rest.immobilienscout24.de/schema/realestate/counts/1.0", AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute("realEstateCounts", Namespace="http://rest.immobilienscout24.de/schema/realestate/counts/1.0")]
    public partial class RealEstateCounts
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("is24publishedRealEstatesCount", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="long")]
        public long Is24publishedRealEstatesCount { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("is24notPublishedRealEstatesCount", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="long")]
        public long Is24notPublishedRealEstatesCount { get; set; }
    }
}
