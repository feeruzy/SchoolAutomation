namespace School.Core;

public class ClassStudentManagement
{
    private readonly ModelDb _db = new ModelDb();


    public IEnumerable<FullUserData> ListStudent()
    {
        var allStudentList = _db.tblStudents;
        foreach (var item in allStudentList)
        {
            var userInfo = new UserManagement().getUserInfo(item.Id);
            var info = new FullUserData()
            {
                Address = item.Address,
                parentPhone = item.ParentNumber,
                Description = item.Comment,
                FName = userInfo.Name,
                Lname = userInfo.Family,
                Phone = userInfo.Phone,
                UserType = (UserTypeEnum) userInfo.UserType,
                Id = item.Id
            };
            yield return info;
        }
    }


    public int createStudent(string fname, string lastName, string phone, string address, string parentPhone, string description)
    {
        int newUserId = new UserManagement().CreateUser(fname, lastName, phone, UserTypeEnum.Student);

        if (_db.tblStudents.Any(u => u.Fk_userId == newUserId))
            throw new ApplicationException("اطلاعات کاربر قبلا در سیستم ثبت شده.");

        var newStudent = new ClassStudent()
        {
            Fk_userId = newUserId,
            Address = address,
            ParentNumber = parentPhone,
            Comment = description,
        };
        _db.tblStudents.Add(newStudent);
        _db.SaveChanges();
        return newStudent.Id;
    }


    // todo: check if user id and student id for editing data.
    public void editStudent(int sId, string fname, string lastName, string phone, string address, string parentPhone, string description)
    {
        if (!_db.tblStudents.Any(x => x.Id == sId))
            throw new ApplicationException("کد کاربر نادرست است.");

        var studenetInfo = _db.tblStudents.FirstOrDefault(x => x.Id == sId);
        new UserManagement().EditUserInfo(studenetInfo.Id, fname, lastName, phone, UserTypeEnum.Student);
        studenetInfo.Address = address;
        studenetInfo.Comment = description;
        studenetInfo.ParentNumber = parentPhone;

        _db.SaveChanges();
    }

    public void removeStudent(int sId)
    {
        if (!_db.tblStudents.Any(x => x.Id == sId))
            throw new ApplicationException("کد کاربر صحیح نمی باشد.");

        var item = _db.tblStudents.FirstOrDefault(x => x.Id == sId);
        _db.tblStudents.Remove(item);


        _db.SaveChanges();

        new UserManagement().removeUser(sId);
    }
}
