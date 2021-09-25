using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace APARecipe.Models
{
    //public class Favorite Recipe 
    //  {

    //      [JsonPropertyName("locale")]
    //      public string Locale { get; }
    //      [JsonPropertyName("Namename")]
    //      public int ID { get; }
    //      [JsonPropertyName("FoodName")]
    //      public int AnimeID { get; }
    //      [JsonPropertyName("number")]
    //      public int Number { get; }
    //      [JsonPropertyName("TitleName")]
    //      public int Title { get; }

    //  }

    //public class Popular Recipe List
    //  {

    //      [JsonPropertyName("locale")]
    //      public string Locale { get; }
    //      [JsonPropertyName("Namename")]
    //      public int ID { get; }
    //      [JsonPropertyName("FoodName")]
    //      public int AnimeID { get; }
    //      [JsonPropertyName("number")]
    //      public int Number { get; }
    //      [JsonPropertyName("TitleName")]
    //      public int Title { get; }

    //  }
    public class Recipe
    {

        [JsonPropertyName("locale")]
        public string Locale { get; }
        [JsonPropertyName("Namename")]
        public int ID { get; }
        [JsonPropertyName("FoodName")]
        public int AnimeID { get; }
        [JsonPropertyName("number")]
        public int Number { get; }
        [JsonPropertyName("TitleName")]
        public int Title { get; }

    }
    public class RecipeList
    {
        [JsonPropertyName("FoodItem")]
        public int StatusCode { get;  }
        [JsonPropertyName("message")]
        public string Message { get;  }
        [JsonPropertyName("Ingredients")]
        public Data Data { get;  }
    }

    public class Data
    {
        [JsonPropertyName("ContentPage")]
        public int CurrentPage { get;  }
        [JsonPropertyName("count")]
        public int Count { get;  }
        [JsonPropertyName("documents")]
        public List<Recipe> Recipes { get;  }
    }

   
}
