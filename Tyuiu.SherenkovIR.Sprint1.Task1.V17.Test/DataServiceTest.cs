using Tyuiu.SherenkovIR.Sprint1.Task1.V17.Lib;
namespace Tyuiu.SherenkovIR.Sprint1.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds  = new DataService();
            double x = 2.0;
            double y = 4.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(24, res);


        }
    }
}
