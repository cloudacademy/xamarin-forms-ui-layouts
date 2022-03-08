using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xaml_UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.TabbedLayoutPage();
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
