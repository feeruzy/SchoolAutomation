namespace School.Core;

/// <summary>
/// کلاس مدیریت سال تحصیلی
/// </summary>
public class YearManager
{
  private readonly ModelDb _db = new ModelDb();

  /// <summary>
  /// لیست سال های تحصیلی ثبت شده در سیستم
  /// </summary>
  /// <returns></returns>
  public List<ClassYear> ListYears()
  {
    return _db.tblYears.ToList();
  }


  /// <summary>
  /// تعریف سال جدید
  /// </summary>
  /// <param name="name">نام سال تحصیلی </param>
  /// <returns>شماره ایدی سال جدید</returns>
  public int CreateYear(string name)
  {
    if (_db.tblYears.Any(i => i.Name == name))
      throw new Exception("نام سال تکراری است.");

    var newYear = new ClassYear()
    {
      Name = name,
      IsActive = false
    };
    _db.tblYears.Add(newYear);
    _db.SaveChanges();

    return newYear.Id;
  }

  /// <summary>
  ///     activate selected year.
  /// </summary>
  /// <param name="id">year id</param>
  public void EditActivation(int id)
  {
    if (!_db.tblYears.Any(i => i.Id == id))
      throw new Exception("سال تحصیلی مورد نظر یافت نشد.");

    foreach (var y in _db.tblYears) y.IsActive = y.Id == id;
    _db.SaveChanges();
  }

}
