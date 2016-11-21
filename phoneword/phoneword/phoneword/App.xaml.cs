using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace phoneword
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            //Handle when your app starts
        }
        protected override void OnSleep()
        {
            //Handle when your app sleep
        }
        protected override void OnResume()
        {
            //handle when your app resumes
        }

    }
}

