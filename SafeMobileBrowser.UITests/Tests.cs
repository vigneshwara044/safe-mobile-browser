using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SafeMobileBrowser.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        static readonly Func<AppQuery, AppQuery> AddressBarEntry = c => c.Marked("AddressBarEntry");
        static readonly Func<AppQuery, AppQuery> HomeActionIcon = c => c.Marked("HomeActionIcon");
        static readonly Func<AppQuery, AppQuery> HyrbidWebView = c => c.Marked("HyrbidWebView").Property("Source").Like("hello");

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            // AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            // app.Screenshot("Welcome screen.");

            AppResult[] result = app.Query(AddressBarEntry);
            AppResult[] result2 = app.Query(HyrbidWebView);
            Assert.AreEqual(result.Any(), result2.Any());
            app.Tap(HomeActionIcon);
            result2 = app.Query(HyrbidWebView);
            Assert.IsTrue(result2.Any(), "The home page is not being displayed");
        }
    }
}
