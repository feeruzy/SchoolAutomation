using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace School.Core;

/// <summary>
/// جدول سال تحصیلی
/// </summary>
[DataContract]
public class MajorClass
{
    /// <summary>
    ///  کد سال
    /// </summary>
    /// <value></value>
    [Key, DataMember] public int Id { get; set; }

    /// <summary>
    /// نام سال
    /// </summary>
    /// <value></value>
    [DataMember] public string Name { get; set; }
}
