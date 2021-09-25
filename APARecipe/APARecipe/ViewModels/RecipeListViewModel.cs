using APARecipe.Models;
using APARecipe.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace APARecipe.ViewModels
{
    public class RecipeListViewModel : PropertyChangedViewModel
    {
        private async void SearchRecipes()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                ////var response = await _edaApiService.Recipe();
                //EpisodesList = new ObservableCollection<Recipe>(response.Data.Recipes);
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "Missing network connection. Try again later", "Ok");
            }
        }
        public RecipeListViewModel(edaAPIservice aniApiService)
        {
            _edaApiService = aniApiService;
            FindRecipeCommand = new Command(SearchRecipes);
        }


        public ObservableCollection<Models.Recipe> EpisodesList { get; set; }
        public ICommand FindRecipeCommand { get; set; }
        private edaAPIservice _edaApiService;
        public RecipeListViewModel() { }

    }
}