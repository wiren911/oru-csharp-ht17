using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class StructsTests
{
    struct Student
    {
        public int Age;
    }

    [TestMethod]
    public void looks_like_reference_behaves_like_value()
    {
        var student = new Student();
        student.Age = 1;
        SetName(student);

        Assert.AreEqual(1, student.Age);
    }

    private void SetName(Student student)
    {
        student.Age = 10;
    }
}