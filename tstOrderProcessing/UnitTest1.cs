using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tstOrderProcessing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            Assert.IsNotNull(anOrderProcessing);

        }
    }
}
