using APARecipe.Models;
using APARecipe.Services;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace APARecipe.Services
{
    public class edaAPIservice : IedaAPIservice
    {
        private IedaAPI _aniApi;

        public const string APIURL = "https://developer.edamam.com/edamam-docs-recipe-api";

        private IJsonSerializerService _serializer = new JsonSerializerService();

      

        public async Task<RecipeList> GetEpisodesAsync()
        {
            var response = await _aniApi.GetEpisodesAsync();

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                var episodesListResponse = _serializer.Deserialize<RecipeList>(responseString);

                return episodesListResponse;
            }

            return null;
        }

        Task<RecipeList> IedaAPIservice.RecipesAsync()
        {
            throw new NotImplementedException();
        }

        public edaAPIservice()
        {
            _aniApi = RestService.For<IedaAPI>(APIURL);
        }
    }
}
