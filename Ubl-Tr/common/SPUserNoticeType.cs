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
[System.Xml.Serialization.XmlRootAttribute("SPUserNotice", Namespace="http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class SPUserNoticeType {
    
    private NoticeReferenceType noticeRefField;
    
    private string explicitTextField;
    
    /// <remarks/>
    public NoticeReferenceType NoticeRef {
        get {
            return this.noticeRefField;
        }
        set {
            this.noticeRefField = value;
        }
    }
    
    /// <remarks/>
    public string ExplicitText {
        get {
            return this.explicitTextField;
        }
        set {
            this.explicitTextField = value;
        }
    }
}