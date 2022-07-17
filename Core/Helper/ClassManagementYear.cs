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
    public IEnumerable<ClassYear> ListYears()
    {
        foreach (var item in _db.tblYears)
            yield return item;
    }


    /// <summary>
    /// تعریف سال جدید
    /// </summary>
    /// <param name="name">نام سال تحصیلی </param>
    /// <returns>شماره ایدی سال جدید</returns>
    public int CreateYear(string name)
    {
        if (_db.tblYears.Any(i => i.Name == name))
            throw new ApplicationException("نام سال تکراری است.");

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
            throw new ApplicationException("سال تحصیلی مورد نظر یافت نشد.");

        foreach (var y in _db.tblYears) y.IsActive = y.Id == id;
        _db.SaveChanges();
    }

    public void removeYear(int id)
    {
        if (!_db.tblYears.Any(i => i.Id == id))
            throw new ApplicationException("کد سال تحصیلی در سیستم وجود ندارد.");

        if (_db.tblDisciplineStudents.Any(i => i.Fk_YearId == id))
            throw new ApplicationException("سال تحصیلی منتخب شما در سایر جداول دارای اطلاعات است و قابل حذف نیست.");

        var item = _db.tblYears.FirstOrDefault(i => i.Id == id);

        if (item.IsActive)
            throw new ApplicationException("سال تحصیلی فعال را نمی توان از سیستم حذف کرد.");

        _db.tblYears.Remove(item);
        _db.SaveChanges();

    }

}
