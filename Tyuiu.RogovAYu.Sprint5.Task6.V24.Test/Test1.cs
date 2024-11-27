using Tyuiu.RogovAYu.Sprint5.Task6.V24.Lib;
namespace Tyuiu.RogovAYu.Sprint5.Task6.V24.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(2,ds.LoadFromDataFile(Path.Combine("C:","DataSprint5","InPutDataFileTask6V24.txt")));
        }
    }
}
