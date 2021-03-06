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
/// This base item is the same as the SectionItemType, except it lacks the
/// recursion created by the inclusion of MainItems sub-group.
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SectionItemType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public abstract partial class SectionBaseType : RepeatingType
{
    
    #region Private fields
    private bool _shouldSerializenewData;
    
    private bool _shouldSerializechangedData;
    
    private bool _shouldSerializeordered;
    
    private bool _ordered;
    
    private bool _changedData;
    
    private bool _newData;
    #endregion
    
    ///// <summary>
    ///// SectionBaseType class constructor
    ///// </summary>
    //public SectionBaseType()
    //{
    //    this._ordered = true;
    //}
    
    /// <summary>
    /// If false, then the form implementation may change the
    /// order of items in the section.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public virtual bool ordered
    {
        get
        {
            return this._ordered;
        }
        set
        {
            if ((_ordered.Equals(value) != true))
            {
                this._ordered = value;
                this.OnPropertyChanged("ordered", value);
            }
            _shouldSerializeordered = true;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool changedData
    {
        get
        {
            return this._changedData;
        }
        set
        {
            if ((_changedData.Equals(value) != true))
            {
                this._changedData = value;
                this.OnPropertyChanged("changedData", value);
            }
            _shouldSerializechangedData = true;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool newData
    {
        get
        {
            return this._newData;
        }
        set
        {
            if ((_newData.Equals(value) != true))
            {
                this._newData = value;
                this.OnPropertyChanged("newData", value);
            }
            _shouldSerializenewData = true;
        }
    }
    
    /// <summary>
    /// Test whether ordered should be serialized
    /// </summary>
    public virtual bool ShouldSerializeordered()
    {
        if (_shouldSerializeordered)
        {
            return true;
        }
        return (_ordered != default(bool));
    }
    
    /// <summary>
    /// Test whether changedData should be serialized
    /// </summary>
    public virtual bool ShouldSerializechangedData()
    {
        if (_shouldSerializechangedData)
        {
            return true;
        }
        return (_changedData != default(bool));
    }
    
    /// <summary>
    /// Test whether newData should be serialized
    /// </summary>
    public virtual bool ShouldSerializenewData()
    {
        if (_shouldSerializenewData)
        {
            return true;
        }
        return (_newData != default(bool));
    }
}
}
#pragma warning restore
