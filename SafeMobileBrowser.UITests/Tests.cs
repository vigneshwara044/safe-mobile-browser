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
        static readonly Func<AppQuery, AppQuery> MenuActionIcon = c => c.Marked("MenuActionIcon");
        static readonly Func<AppQuery, AppQuery> SettingsPageIcon = c => c.Marked("NoResourceEntry-24");
        static readonly Func<AppQuery, AppQuery> AppLogsLabel = c => c.Marked("NoResourceEntry - 37");
        static readonly Func<AppQuery, AppQuery> DeleteAllAppLogsIcon = c => c.Id("Delete All logs");
        static readonly Func<AppQuery, AppQuery> FaqLabel = c => c.Marked("NoResourceEntry-39");
        static readonly Func<AppQuery, AppQuery> PrivacyStatementLabel = c => c.Marked("NoResourceEntry-40");

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

        [Test]
        public void SettingsPageTest()
        {
            app.Tap(MenuActionIcon);
            app.Repl();

            // Opening Settings Page
            app.Tap(SettingsPageIcon);
            app.Tap(FaqLabel);
        }

        [Test]
        public void DeleteApplogsTest()
        {
            app.Tap(MenuActionIcon);
            app.Tap(SettingsPageIcon);
            app.Tap(AppLogsLabel);
            app.Repl();
            app.Tap(DeleteAllAppLogsIcon);
            app.Screenshot("Deleted app logs");
        }
    }
}
