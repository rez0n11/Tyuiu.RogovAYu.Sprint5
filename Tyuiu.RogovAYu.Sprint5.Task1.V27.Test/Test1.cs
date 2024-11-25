using Tyuiu.RogovAYu.Sprint5.Task1.V27.Lib;
namespace Tyuiu.RogovAYu.Sprint5.Task1.V27.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string a = ds.SaveToFileTextData(-5,5);
            FileInfo fileInfo = new FileInfo(a);
            Assert.AreEqual(true, fileInfo.Exists);
        }
    }
}
