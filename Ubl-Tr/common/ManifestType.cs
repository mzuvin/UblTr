//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("Manifest", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class ManifestType {
    
    private ReferenceType1[] referenceField;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Reference")]
    public ReferenceType1[] Reference {
        get {
            return this.referenceField;
        }
        set {
            this.referenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}