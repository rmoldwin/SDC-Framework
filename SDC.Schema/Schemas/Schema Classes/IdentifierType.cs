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
/// A code or id that identifies a person or organization or object according to a standard system such as CLIA or NPI. The system should be specified in the @system attribute.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class IdentifierType : ExtensionBaseType
{
    
    #region Private fields
    private string _system;
    
    private string _val;
    #endregion
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string system
    {
        get
        {
            return this._system;
        }
        set
        {
            if ((this._system == value))
            {
                return;
            }
            if (((this._system == null) 
                        || (_system.Equals(value) != true)))
            {
                this._system = value;
                this.OnPropertyChanged("system", value);
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
    /// Test whether system should be serialized
    /// </summary>
    public virtual bool ShouldSerializesystem()
    {
        return !string.IsNullOrEmpty(system);
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
