namespace School.Core;

/// <summary>
/// مدیریت موارد انضباطی برای یک دانش  آموز
/// </summary>
public class ClassDisciplineStudentManager
{

    private readonly ModelDb _db = new ModelDb();

    /// <summary>
    /// لیست موارد انضباطی برای یک دانش آموز مشخص
    /// </summary>
    /// <param name="studentId">شماره دانش آموزی</param>
    /// <returns>موارد انظباطی مرتبط با دانش آموز.</returns>
    public IEnumerable<ClassDiciplineStudent> List(int studentId)
    {
        if (!_db.tblStudents.Any(i => i.Id == studentId))
            throw new ApplicationException("شماره دانش آموز نامعتبر است.");

        var allEventForOneStudent = _db.tblDisciplineStudents.Where(i => i.Fk_StudentId == studentId).OrderByDescending(i=> i.Date);
        foreach (var item in allEventForOneStudent)
            yield return item;
    }

    /// <summary>
    /// ثبت مورد انضباطی برای دانش آموز
    /// </summary>
    /// <param name="studentId">شماره دانش آموزی</param>
    /// <param name="dt">تاریخ رویداد</param>
    /// <param name="disciplineId">کد مورد انضباطی</param>
    /// <returns>آي دی مورد انظباطی ثبت شده برای دانش آموز.</returns>
    public int AddEventForStudent(int studentId, DateTime dt, int disciplineId)
    {
        if (!_db.tblYears.Any(i => i.IsActive))
            throw new ApplicationException("سال تحصیلی فعال در سیستم تعریف نشده است.");

        if (!_db.tblStudents.Any(i => i.Id == studentId))
            throw new ApplicationException("شماره دانش آموزی نامعتبر.");

        if (!_db.tblDisciplines.Any(i => i.Id == disciplineId))
            throw new ApplicationException("مورد انضباطی نامشخص.");

        var eventItem = new ClassDiciplineStudent()
        {
            Fk_YearId = _db.tblYears.FirstOrDefault(i => i.IsActive).Id,
            Date = dt,
            Fk_DiciplineId = disciplineId,
            Fk_StudentId = studentId
        };

        _db.tblDisciplineStudents.Add(eventItem);
        _db.SaveChanges();

        return eventItem.Id;
    }

    /// <summary>
    /// حذف مورد انضباطی ثبت شده
    /// </summary>
    /// <param name="itemId">id discipline student item</param>
    public void remveEventItem(int itemId)
    {
        if (!_db.tblDisciplineStudents.Any(i => i.Id == itemId))
            throw new ApplicationException("شماره درخواست نامعتبر است.");

        var item = _db.tblDisciplineStudents.FirstOrDefault(i => i.Id == itemId);
        _db.tblDisciplineStudents.Remove(item);
        _db.SaveChanges();
    }
}
