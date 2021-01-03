﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace UITests
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class SmokeTest
    {
        const string _homePageUrl = "http://52.174.156.60/mvcmusicstore_deploy/";
        public SmokeTest()
        {
        }

        [TestMethod]
        public void HomepageContainsProducts()
        {
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.Disabled;
            var bw = BrowserWindow.Launch(_homePageUrl);
            var home = new HomePage(bw);
            Assert.IsTrue( home.PageHasProductsListed(),"Expected to have products on the home page and they are not found");
        }

        [TestMethod]
        public void CanAddProductToShoppingBasketAndCheckOut()
        {

            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.Disabled;
            var bw = BrowserWindow.Launch(_homePageUrl);
            var home = new HomePage(bw);
            Assert.IsTrue(
            home.ClickFirstProduct()
                .AddToChart()
                .Checkout()
                .IsCheckoutPageValid(),"Expected checkout page would be valid after adding one item to the basket and click checkout");
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
