using Tyuiu.RogovAYu.Sprint5.Task3.V14.Lib;
namespace Tyuiu.RogovAYu.Sprint5.Task3.V14.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string a = ds.SaveToFileTextData(3);
            Assert.AreEqual(true,new FileInfo(a).Exists);
        }
    }
}
