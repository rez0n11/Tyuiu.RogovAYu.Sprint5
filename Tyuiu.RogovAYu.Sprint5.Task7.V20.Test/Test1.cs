using Tyuiu.RogovAYu.Sprint5.Task7.V20.Lib;

namespace Tyuiu.RogovAYu.Sprint5.Task7.V20.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual("Ссловарные слова с удвоенной согласной нн", ds.LoadDataAndSave(Path.Combine("C:","DataSprint5","InPutDataFileTask7V20.txt")));
        }
    }
}
