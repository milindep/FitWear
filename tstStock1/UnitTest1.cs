using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tstStock1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStock anStock = new clsStock();

            Assert.IsNotNull(anStock);
        }
    }
}
