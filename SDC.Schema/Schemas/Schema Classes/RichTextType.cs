// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 5.1.87.0. www.xsd2code.com
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace SDC.Schema
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

/// <summary>
/// Representation of plain text with an option for HTML-formatting. Contains optional boilerplate metadata to aid programmatic manipulation.
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ActSendMessageType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class RichTextType : ExtensionBaseType
{
    
    #region Private fields
    private HTML_Stype _richText;
    
    private string _val;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public virtual HTML_Stype RichText
    {
        get
        {
            return this._richText;
        }
        set
        {
            if ((this._richText == value))
            {
                return;
            }
            if (((this._richText == null) 
                        || (_richText.Equals(value) != true)))
            {
                this._richText = value;
                this.OnPropertyChanged("RichText", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string val
    {
        get
        {
            return this._val;
        }
        set
        {
            if ((this._val == value))
            {
                return;
            }
            if (((this._val == null) 
                        || (_val.Equals(value) != true)))
            {
                this._val = value;
                this.OnPropertyChanged("val", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether RichText should be serialized
    /// </summary>
    public virtual bool ShouldSerializeRichText()
    {
        return (_richText != null);
    }
    
    /// <summary>
    /// Test whether val should be serialized
    /// </summary>
    public virtual bool ShouldSerializeval()
    {
        return !string.IsNullOrEmpty(val);
    }
}
}
#pragma warning restore