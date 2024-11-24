using Tyuiu.RogovAYu.Sprint5.Task0.V15.Lib;
namespace Tyuiu.RogovAYu.Sprint5.Task0.V15.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string a = ds.SaveToFileTextData(3);
            FileInfo fileInfo = new FileInfo(a);
            Assert.AreEqual(true, fileInfo.Exists);
        }
    }
}
