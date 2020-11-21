using Moq;
using NUnit.Framework;
using Resolutium.FeatureFlags;
using Resolutium.InterviewConstructService;

namespace Resolutium.UnitTests
{
    public class FeatureFlagServiceTests
    {
        Mock<IFeatureFlagService> mockInterfcace;
        ServiceAccess serviceAccess;

        [SetUp]
        public void Setup()
        {
            mockInterfcace = new Mock<IFeatureFlagService>(MockBehavior.Strict) 
                                    { DefaultValue = DefaultValue.Empty };
        }
        [Test]
        //Validate the Sales module acccessible with value 'Enabled'
        public void Validate_SalesModule_Access()
        {
            string key = "Resolutium.Sales";
            mockInterfcace.Setup(x => x.Get(key)).Returns(new FeatureFlag(key) { Value = "Enabled" });
            serviceAccess = new ServiceAccess();
            string actualResult = serviceAccess.SalesAccess(mockInterfcace.Object.Get(key));
            Assert.AreEqual("You have access to the sales module.", actualResult);
        }
        [Test]
        //Validate the Sales module inaccessible for other values
        public void Validate_SalesModule_InAccessible()
        {
            string key = "Resolutium.Sales";
            mockInterfcace.Setup(x => x.Get(key)).Returns(new FeatureFlag(key) { Value = It.IsAny<string>() });
            serviceAccess = new ServiceAccess();
            string actualResult = serviceAccess.SalesAccess(mockInterfcace.Object.Get(key));
            Assert.AreEqual("You don't have access to the sales module.", actualResult);
        }
        [Test]
        public void Validate_AccountingModule_Accessible()
        {
            string key = "Resolutium.Accounting";
            mockInterfcace.Setup(x => x.Get(key)).Returns(new FeatureFlag(key) { Value = "Enabled" });
            serviceAccess = new ServiceAccess();
            string actualResult = serviceAccess.AccountingAccess(mockInterfcace.Object.Get(key));
            Assert.AreEqual("You have access to the accounting module.", actualResult);
        }

        [Test]
        public void Validate_AccountingModule_InAccessible()
        {
            string key = "Resolutium.Accounting";
            mockInterfcace.Setup(x => x.Get(key)).Returns(new FeatureFlag(key) { Value = It.IsAny<string>() });
            serviceAccess = new ServiceAccess();
            string actualResult = serviceAccess.AccountingAccess(mockInterfcace.Object.Get(key));
            Assert.AreEqual("You don't have access to the accounting module.", actualResult);
        }
        [Test]
        public void Validate_PurchasingModule_Accessible()
        {
            string key = "Resolutium.Purchasing";
            mockInterfcace.Setup(x => x.Get(key)).Returns(new FeatureFlag(key) { Value = "Enabled" });
            serviceAccess = new ServiceAccess();
            string actualResult = serviceAccess.PurchaseAccess(mockInterfcace.Object.Get(key));
            Assert.AreEqual("You have access to the purchasing module.", actualResult);
        }
        [Test]
        public void Validate_PurchasingModule_InAccessible()
        {
            string key = "Resolutium.Purchasing";
            mockInterfcace.Setup(x => x.Get(key)).Returns(new FeatureFlag(key) { Value = It.IsAny<string>() });
            serviceAccess = new ServiceAccess();
            string actualResult = serviceAccess.PurchaseAccess(mockInterfcace.Object.Get(key));
            Assert.AreEqual("You don't have access to the purchasing module.", actualResult);
        }
        [Test]
        public void Validate_ReportingModule_Accessible()
        {
            string key = "Resolutium.Reporting";
            mockInterfcace.Setup(x => x.Get(key)).Returns(new FeatureFlag(key) { Value = "Enabled" });
            serviceAccess = new ServiceAccess();
            string actualResult = serviceAccess.ReportingAccess(mockInterfcace.Object.Get(key));
            Assert.AreEqual("You have access to the reporting module.", actualResult);
        }
        [Test]
        public void Validate_ReportingModule_InAccessible()
        {
            string key = "Resolutium.Reporting";
            mockInterfcace.Setup(x => x.Get(key)).Returns(new FeatureFlag(key) { Value = It.IsAny<string>() });
            serviceAccess = new ServiceAccess();
            string actualResult = serviceAccess.ReportingAccess(mockInterfcace.Object.Get(key));
            Assert.AreEqual("You don't have access to the reporting module.", actualResult);
        }
        [TearDown]
        public void TearDown()
        {
            mockInterfcace.VerifyAll();
        }
    }
}