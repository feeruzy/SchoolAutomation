using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace School.Core;

/// <summary>
/// جدول موارد انضباطی و دانش آموزان
/// </summary>

[DataContract]

public class ClassDiciplineStudent
{
    [Key, DataMember] public int Id { get; set; }

    /// نوع مورد انضباطی
    [DataMember] public int Fk_DiciplineId { get; set; }  // manual foreign key

    /// تاریخ رویداد
    [DataMember] public DateTime Date { get; set; }

    /// سال تحصیلی
    [DataMember] public int Fk_YearId { get; set; } // manaul foreign key
}