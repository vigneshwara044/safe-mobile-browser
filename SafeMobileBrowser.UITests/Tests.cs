using System;
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
        static readonly Func<AppQuery, AppQuery> FocusActionIcon = c => c.Marked("FocusActionIcon");

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
        public void AddressBarFocusTest()
        {
            app.Tap(FocusActionIcon);
            AppResult[] result1 = app.Query(AddressBarEntry);
            app.EnterText(AddressBarEntry, "hello");
        }
    }
}
