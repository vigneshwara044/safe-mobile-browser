using Xamarin.UITest;

namespace SafeMobileBrowser.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .InstalledApp("net.maidsafe.browser")
                    .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}
