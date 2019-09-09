using System;
using Xamarin;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SafeMobileBrowser.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            var packageIdentifier = "net.maidsafe.browser";
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .InstalledApp(packageIdentifier)
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .InstalledApp(packageIdentifier)
                .StartApp();
        }
    }
}
