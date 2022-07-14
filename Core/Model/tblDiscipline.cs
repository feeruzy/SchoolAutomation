using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace School.Core;

/// <summary>
/// جدول موارد انضباطی
/// </summary>

[DataContract]
public class ClassDiscipline
{
    [Key, DataMember] public int Id { get; set; }
    [DataMember] public string Title { get; set; }
    [DataMember] public float KasreNomre { get; set; }
}
