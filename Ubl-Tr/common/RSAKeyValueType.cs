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
[System.Xml.Serialization.XmlRootAttribute("RSAKeyValue", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class RSAKeyValueType {
    
    private byte[] modulusField;
    
    private byte[] exponentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Modulus {
        get {
            return this.modulusField;
        }
        set {
            this.modulusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Exponent {
        get {
            return this.exponentField;
        }
        set {
            this.exponentField = value;
        }
    }
}