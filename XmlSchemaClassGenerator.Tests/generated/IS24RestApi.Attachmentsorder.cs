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
namespace IS24RestApi.Attachmentsorder
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para xml:lang="de-DE">Ordered list of the attachments.</para>
    /// <para xml:lang="en">Eine geordnete Liste der Anhänge.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.4.5468.25949")]
    [System.Xml.Serialization.XmlTypeAttribute("list", Namespace="http://rest.immobilienscout24.de/schema/attachmentsorder/1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("attachmentsorder", Namespace="http://rest.immobilienscout24.de/schema/attachmentsorder/1.0")]
    public partial class List
    {
        
        /// <summary>
        /// <para xml:lang="de-DE">Id des Anhanges.</para>
        /// <para xml:lang="en">Id of the attachment.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("attachmentId", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="long")]
        public System.Collections.ObjectModel.Collection<long> AttachmentId { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AttachmentId-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AttachmentId collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AttachmentIdSpecified
        {
            get
            {
                return (this.AttachmentId.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="List" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="List" /> class.</para>
        /// </summary>
        public List()
        {
            this.AttachmentId = new System.Collections.ObjectModel.Collection<long>();
        }
    }
}
