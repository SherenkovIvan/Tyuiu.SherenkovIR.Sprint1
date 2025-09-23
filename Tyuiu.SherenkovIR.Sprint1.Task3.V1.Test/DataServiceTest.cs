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
            double r = 4.32;
            double h = 1.23;
            double wait = 5.314;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(wait , res);
        }
    }
}
