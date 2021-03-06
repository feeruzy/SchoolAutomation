using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace School.Core;

/// <summary>
/// جدول سال‌های تحصیلی
/// </summary>
[DataContract]
public class ClassYear {
  [Key, DataMember] public int Id { get; set; }
  [DataMember] public string Name { get; set; }
  [DataMember] public bool IsActive { get; set; }
}
