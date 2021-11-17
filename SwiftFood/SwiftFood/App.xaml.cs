using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// Importing Custom Fonts
[assembly: ExportFont("BentonSans Bold.otf", Alias = "BentonBold")]
[assembly: ExportFont("BentonSans Medium.otf", Alias = "BentonMedium")]
[assembly: ExportFont("BentonSans Regular.otf", Alias = "BentonRegular")]


namespace SwiftFood
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //MainPage = new NavigationPage( new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

