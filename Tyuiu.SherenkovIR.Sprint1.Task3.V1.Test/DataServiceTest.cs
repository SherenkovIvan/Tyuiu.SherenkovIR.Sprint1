using Tyuiu.SherenkovIR.Sprint1.Task3.V1.Lib;
namespace Tyuiu.SherenkovIR.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 1.4142;
            double h = 1;
            double wait = 6.283;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(wait , res);
        }
    }
}
