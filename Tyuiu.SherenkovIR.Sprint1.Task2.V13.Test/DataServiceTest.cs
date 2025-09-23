using Tyuiu.SherenkovIR.Sprint1.Task2.V13.Lib;

namespace Tyuiu.SherenkovIR.Sprint1.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 6;
            var res = ds.ConvertMilesToKm (x);
            Assert.AreEqual (10.142, res);
        }
    }
}
