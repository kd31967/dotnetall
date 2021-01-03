using MvcMusicStore.Featuretoggles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnit.UnitTests
{
    public class Class1
    {
        [Fact]
        public void NUnitTestfeaturetoggleEnabled()
        {
            HomePagefeatureToggle.Current.TurnOn();
            Assert.True(HomePagefeatureToggle.Current.FeatureEnabled);
        }
        [Fact]
        public void NUnitTestfeaturetoggleDisabled()
        {
            HomePagefeatureToggle.Current.TurnOff();
            Assert.False(HomePagefeatureToggle.Current.FeatureEnabled);
        }
    }
}
