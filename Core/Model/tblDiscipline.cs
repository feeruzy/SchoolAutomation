using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace School.Core;

/// <summary>
/// جدول موارد انضباطی
/// </summary>

[DataContract]
public class ClassDicipline
{
    [Key, DataMember] public int Id { get; set; }
    [DataMember] public string Titr { get; set; }
    [DataMember] public int KasreNomre { get; set; }
}