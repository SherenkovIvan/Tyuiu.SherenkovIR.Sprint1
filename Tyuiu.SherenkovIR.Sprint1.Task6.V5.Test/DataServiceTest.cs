
using Tyuiu.SherenkovIR.Sprint1.Task6.V5.Lib;
namespace Tyuiu.SherenkovIR.Sprint1.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {

            string strTest = "казак шалаш";
            DataService ds = new DataService();
            string res = ds.CheckSymmetricalWords(strTest);
            string wait = "казак, шалаш";
            Assert.AreEqual(wait, res);

        }
    }             
}

