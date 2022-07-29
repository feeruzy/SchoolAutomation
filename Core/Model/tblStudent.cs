using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
    [DataMember] public int Fk_userId { get; set; }
    [DataMember] public string ParentNumber { get; set; }
    [DataMember] public string Address { get; set; }
    [DataMember] public string Comment { get; set; }

    [ForeignKey(nameof(Fk_userId))] 
    [DataMember] public virtual ClassUser User { get; set; }
}






public class FullUserData
{
    public int Id { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public string FName { get; set; }
    public string Lname { get; set; }
    public string Phone { get; set; }
    public string parentPhone {get; set;}
    public UserTypeEnum UserType { get; set; }
}