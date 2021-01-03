using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcMusicStore.Featuretoggles;

namespace MsTest.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestfeaturetoggleEnabled()
        {
            HomePagefeatureToggle.Current.TurnOn();
            Assert.IsTrue(HomePagefeatureToggle.Current.FeatureEnabled);
        }
        [TestMethod]
        public void TestfeaturetoggleDisabled()
        {
            HomePagefeatureToggle.Current.TurnOff();
            Assert.IsFalse(HomePagefeatureToggle.Current.FeatureEnabled);
        }
    }
}
