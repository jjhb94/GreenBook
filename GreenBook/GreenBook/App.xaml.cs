using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GreenBook.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace GreenBook
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new Home(); // this is where you set the starting page for the application
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
