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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://uri.etsi.org/01903/v1.3.2#")]
public partial class OCSPIdentifierType {
    
    private ResponderIDType responderIDField;
    
    private System.DateTime producedAtField;
    
    private string uRIField;
    
    /// <remarks/>
    public ResponderIDType ResponderID {
        get {
            return this.responderIDField;
        }
        set {
            this.responderIDField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime ProducedAt {
        get {
            return this.producedAtField;
        }
        set {
            this.producedAtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string URI {
        get {
            return this.uRIField;
        }
        set {
            this.uRIField = value;
        }
    }
}