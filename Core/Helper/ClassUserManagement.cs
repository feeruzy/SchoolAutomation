namespace School.Core;

public class UserManagement
{
    private readonly ModelDb _db = new ModelDb();

    public IEnumerable<ClassUser> List()
    {
        foreach (var item in _db.tblUsers)
            yield return item;
    }

    public int CreateUser(string fname, string lastName, string phone, UserTypeEnum userType)
    {
        ClassUser newItem = new ClassUser()
        {
            Name = fname,
            Family = lastName,
            Phone = phone,
            UserType = userType
        };
        _db.tblUsers.Add(newItem);
        _db.SaveChanges();
        return newItem.Id;
    }

    public void EditUserInfo(int userId, string fname, string lastName, string phone, UserTypeEnum userType)
    {

        if (!_db.tblUsers.Any(i => i.Id == userId))
            throw new ApplicationException("کد کاربر نادرست است.");


        var item = _db.tblUsers.FirstOrDefault(i => i.Id == userId);
        item.Name = fname;
        item.Family = lastName;
        item.Phone = phone;
        item.UserType = userType;

        _db.SaveChanges();

    }

    public void removeUser(int userId)
    {

        if (!_db.tblUsers.Any(i => i.Id == userId))
            throw new ApplicationException("کد کاربر نادرست است.");


        var item = _db.tblUsers.FirstOrDefault(i => i.Id == userId);
        _db.tblUsers.Remove(item);
        _db.SaveChanges();

    }



}
