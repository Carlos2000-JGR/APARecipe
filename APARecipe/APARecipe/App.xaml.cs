using APARecipe.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APARecipe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RecipeView());
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
