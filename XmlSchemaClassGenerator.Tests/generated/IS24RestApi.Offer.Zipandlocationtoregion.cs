//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 0.4.5468.25949.
namespace IS24RestApi.Offer.Zipandlocationtoregion
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.4.5468.25949")]
    [System.Xml.Serialization.XmlTypeAttribute("priceRegionAssignment", Namespace="http://rest.immobilienscout24.de/schema/offer/zipandlocationtoregion/1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("priceRegionAssignment", Namespace="http://rest.immobilienscout24.de/schema/offer/zipandlocationtoregion/1.0")]
    public partial class PriceRegionAssignment
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("region", Namespace="http://rest.immobilienscout24.de/schema/offer/zipandlocationtoregion/1.0")]
        public PriceRegion Region { get; set; }
    }
    
    /// <summary>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.4.5468.25949")]
    [System.Xml.Serialization.XmlTypeAttribute("priceRegion", Namespace="http://rest.immobilienscout24.de/schema/offer/zipandlocationtoregion/1.0")]
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
