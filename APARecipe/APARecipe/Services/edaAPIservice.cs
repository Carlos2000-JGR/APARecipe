using APARecipe.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APARecipe.Services
{  
    public interface IedaAPIservice
    {
        Task<RecipeList> RecipesAsync();
    }
}
