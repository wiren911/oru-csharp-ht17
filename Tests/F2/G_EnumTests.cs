using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class EnumTests
{
    enum DaysInWeek
    {
        NotFriday,
        Friday,
        Saturday = 100
    }

    [TestMethod]
    public void assignment()
    {
        var day = DaysInWeek.NotFriday;
        Assert.AreEqual(0, (int)day);

        day = DaysInWeek.Saturday;
        Assert.AreEqual(100, (int)day);

        Assert.AreEqual("Saturday", day.ToString());
    }

    [Flags]
    enum Role
    {
        Student = 1,
        Teacher = 2,
        GuestTeacher = 4
    }

    [TestMethod]
    public void flags_enum()
    {
        var amanuens = Role.Student | Role.Teacher;
        Assert.AreEqual(3, (int)amanuens);

        Assert.AreEqual(true, amanuens.HasFlag(Role.Student));

        var johan = Role.Teacher | Role.GuestTeacher;
        Assert.AreEqual(6, (int)johan);        
    }
}