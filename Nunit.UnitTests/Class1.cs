using MvcMusicStore.Featuretoggles;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit.UnitTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void NUnitTestfeaturetoggleEnabled()
        {
            HomePagefeatureToggle.Current.TurnOn();
            Assert.IsTrue(HomePagefeatureToggle.Current.FeatureEnabled);
        }
        [Test]
        public void NUnitTestfeaturetoggleDisabled()
        {
            HomePagefeatureToggle.Current.TurnOff();
            Assert.IsFalse(HomePagefeatureToggle.Current.FeatureEnabled);
        }
    }
}
