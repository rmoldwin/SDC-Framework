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
/// LookupEndPointType represents list items that are derived from a web
/// service call of some type, instead of an explicit set of ListItem nodes specified in
/// the FormDesign XML. The endpoint must return a list separated into individual list
/// items by the @colTextDelimiter value specified in the parent
/// ListFieldType.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class LookupEndPointType : CallFuncActionType
{
    
    #region Private fields
    private bool _shouldSerializeincludesHeaderRow;
    
    private List<CodingType> _responseValue;
    
    private bool _includesHeaderRow;
    #endregion
    
    ///// <summary>
    ///// LookupEndPointType class constructor
    ///// </summary>
    //public LookupEndPointType()
    //{
    //    this._includesHeaderRow = false;
    //}
    
    /// <summary>
    /// The user's response to the lookup list. The response
    /// is recorded as a coding, terminology, classification, keyword, or
    /// local value. Multiple selections from the lookup list may be
    /// allowed.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("ResponseValue", Order=0)]
    public virtual List<CodingType> ResponseValue
    {
        get
        {
            return this._responseValue;
        }
        set
        {
            if ((this._responseValue == value))
            {
                return;
            }
            if (((this._responseValue == null) 
                        || (_responseValue.Equals(value) != true)))
            {
                this._responseValue = value;
                this.OnPropertyChanged("ResponseValue", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public virtual bool includesHeaderRow
    {
        get
        {
            return this._includesHeaderRow;
        }
        set
        {
            if ((_includesHeaderRow.Equals(value) != true))
            {
                this._includesHeaderRow = value;
                this.OnPropertyChanged("includesHeaderRow", value);
            }
            _shouldSerializeincludesHeaderRow = true;
        }
    }
    
    /// <summary>
    /// Test whether ResponseValue should be serialized
    /// </summary>
    public virtual bool ShouldSerializeResponseValue()
    {
        return ResponseValue != null && ResponseValue.Count > 0;
    }
    
    /// <summary>
    /// Test whether includesHeaderRow should be serialized
    /// </summary>
    public virtual bool ShouldSerializeincludesHeaderRow()
    {
        if (_shouldSerializeincludesHeaderRow)
        {
            return true;
        }
        return (_includesHeaderRow != default(bool));
    }
}
}
#pragma warning restore
