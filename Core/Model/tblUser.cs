using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace School.Core;

/// <summary>
///   جدول کلی کاربران
/// </summary>
[DataContract]
public class ClassUser
{
  [Key, DataMember] public int Id { get; set; }
  [DataMember] public string Name { get; set; }
  [DataMember] public string Family { get; set; }
  [DataMember] public string Phone { get; set; }
  [DataMember] public UserTypeEnum UserType { get; set; }
}
