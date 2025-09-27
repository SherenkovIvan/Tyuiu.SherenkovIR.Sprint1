using Tyuiu.SherenkovIR.Sprint1.Task7.V29.Lib;
namespace Tyuiu.SherenkovIR.Sprint1.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 2.099;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
