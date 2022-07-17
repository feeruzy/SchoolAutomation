namespace School.Core;

public class DisciplineManagement
{
    private readonly ModelDb _db = new ModelDb();

    public IEnumerable<ClassDiscipline> List()
    {
        foreach (var item in _db.tblDisciplines)
            yield return item;
    }

    public int CreateDisciplineItem(string title, float score)
    {
        if (_db.tblDisciplines.Any(d => d.Title == title))
            throw new ApplicationException("عنوان تکراری است");

        ClassDiscipline newItem = new ClassDiscipline()
        {
            KasreNomre = score,
            Title = title
        };

        _db.tblDisciplines.Add(newItem);
        _db.SaveChanges();
        return newItem.Id;
    }

    public void EditDisciplineItem(int id, string newTitle, float newKasreNomre)
    {

        if (!_db.tblDisciplines.Any(i => i.Id == id))
            throw new ApplicationException("مورد انظباطی یافت نشد");

        var item = _db.tblDisciplines.FirstOrDefault(i => i.Id == id);
        item.Title = newTitle;
        item.KasreNomre = newKasreNomre;
        _db.SaveChanges();

    }

    public void RemoveDisciplineItem(int id)
    {
        if (!_db.tblDisciplines.Any(i => i.Id == id))
            throw new ApplicationException("کد مورد انضباطی نادرست است.");

        if (_db.tblDisciplineStudents.Any(i => i.Fk_DiciplineId == id))
            throw new ApplicationException("مورد انضباطی قبلا استفاده شده و قابل حذف نمی باشد.");

        var item = _db.tblDisciplines.FirstOrDefault(i => i.Id == id);
        _db.tblDisciplines.Remove(item);
        _db.SaveChanges();
    }
}
