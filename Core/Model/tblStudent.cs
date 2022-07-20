using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace School.Core;

/// <summary>
/// جدول دانش آموزان
/// </summary>

[DataContract]

public class ClassStudent
{
    [Key, DataMember] public int Id { get; set; }
    /// شماره دانش آموزی
    [DataMember] public int FK_StudentNumber { get; set; }
    [DataMember] public string ParentNumber { get; set; }
    [DataMember] public string Address { get; set; }
    [DataMember] public string Comment { get; set; }
}

