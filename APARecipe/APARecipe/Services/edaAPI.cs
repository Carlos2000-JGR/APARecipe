using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APARecipe.Services
{
    public interface IedaAPI
    {
        [Get("GET /api/menu-items/v2/search")]
        Task<HttpResponseMessage> GetEpisodesAsync();
    }
}
