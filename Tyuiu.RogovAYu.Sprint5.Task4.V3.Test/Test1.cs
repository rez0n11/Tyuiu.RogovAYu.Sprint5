using Tyuiu.RogovAYu.Sprint5.Task4.V3.Lib;
namespace Tyuiu.RogovAYu.Sprint5.Task4.V3.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(3.591, ds.LoadFromDataFile(Path.Combine("C:","DataSprint5", "InPutDataFileTask4V3.txt")));
        }

    }
}
