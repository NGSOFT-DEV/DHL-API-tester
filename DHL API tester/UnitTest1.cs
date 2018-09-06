using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DHL_API_tester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void requestPackageSizeForProduct_ShouldReturnAvailableOptions()
        {
            var response = DHLAPIBridge.RateRequest.send();
        }

        
    }
}
