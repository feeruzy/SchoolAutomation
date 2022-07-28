using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace School.Core;

/// <summary>
/// جدول رشته تحصیلی
/// </summary>
[DataContract]
public class FieldClass
{
    /// <summary>
    ///  کد رشته
    /// </summary>
    /// <value></value>
    [Key, DataMember] public int Id { get; set; }

    /// <summary>
    /// نام رشته
    /// </summary>
    /// <value></value>
    [DataMember] public string Name { get; set; }
}


