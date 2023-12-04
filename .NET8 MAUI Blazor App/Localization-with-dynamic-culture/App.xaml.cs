using System.Globalization;

namespace LocalizationMauiBlazor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var language = Preferences.Get("language", "en-US");
            var culture = new CultureInfo(language);
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            MainPage = new MainPage();
        }
    }
}
