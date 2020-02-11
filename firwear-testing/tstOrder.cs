using System;
using FitWear_classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace firwear_testing
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderProcessing anOrderProcessing = new clsOrderProcessing();
            Assert.IsNotNull(anOrderProcessing);

        }

    }
}
