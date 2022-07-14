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

  public void EditDisciplineItem() {
    // todo: check this.
    // tip: check if item found then select it and update its properties.
  }

  public void RemoveDisciplineItem() {
    // todo: check this.
    // tip: first check if discipline item used in discipline student table.
    // if not used it can be remove.
  }
}
