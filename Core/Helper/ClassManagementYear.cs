namespace School.Core;

/// <summary>
/// کلاس مدیریت سال تحصیلی
/// </summary>
public class YearManager
{
    /// <summary>
    /// لیست سال های تحصیلی ثبت شده در سیستم
    /// </summary>
    /// <returns></returns>
    public List<ClassYear> ListYears() {

        return new ModelDb().tblYears.ToList();
    }

    
    /// <summary>
    /// تعریف سال جدید
    /// </summary>
    /// <param name="name">نام سال تحصیلی </param>
    /// <returns>شماره ایدی سال جدید</returns>
    public int CreateYear(string name) {
        var _db = new ModelDb();
        
        if (_db.tblYears.Any(i => i.Name == name)) 
            throw new Exception("نام سال تکراری است.");

        var newYear = new ClassYear() {
            Name = name,
            IsActive = false
        };
        _db.tblYears.Add(newYear);
        _db.SaveChanges();

        return newYear.Id;
    }


    public void EditActivation(int id) {
        var _db = new ModelDb(); 

        if(!_db.tblYears.Any(i => i.Id == id))
            throw new Exception ("سال تحصیلی مورد نظر یافت نشد.");

        var allYears = _db.tblYears;
        foreach (var y in allYears)
            y.IsActive = false;

        var item = _db.tblYears.FirstOrDefault(i => i.Id == id);
        item.IsActive = true;
        _db.SaveChanges();
    }

}