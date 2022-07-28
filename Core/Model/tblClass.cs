using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace School.Core;

/// <summary>
/// جدول کلاس 
/// </summary>
[DataContract]
public class TblClass
{
    /// <summary>
    ///  کد کلاس
    /// </summary>
    /// <value></value>
    [Key, DataMember] public int Id { get; set; }

    /// <summary>
    /// نام کلاس
    /// </summary>
    /// <value></value>
    [DataMember] public string Name { get; set; }

    /// <summary>
    ///     کد سال
    /// </summary>
    /// <value></value>
    [DataMember] public int Fk_Major { get; set; }

    /// <summary>
    /// کد رشته
    /// </summary>
    /// <value></value>
    [DataMember] public int FK_Field { get; set; }
}

