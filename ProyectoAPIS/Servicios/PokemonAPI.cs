using Newtonsoft.Json;
using ProyectoAPIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAPIS.Servicios
{
    class PokemonAPI
    {
        public HttpClient httpclient;
        public PokemonAPI()
        {
            httpclient = new HttpClient();
        }
        public async Task<List<PokemonInfo>> DevuelveListadoPokemon()
        {
            string url = "https://pokeapi.co/api/v2/ability/?limit=40&offset=0";
            string json = await httpclient.GetStringAsync(url);
            ResourceList resourcelist_pokemon = JsonConvert.DeserializeObject<ResourceList>(json);
            return resourcelist_pokemon.results;
        }

        public async Task<CaracteristicasPokemon> DevuelveCaracteristicasPokemon(string url)
        {
            string json = await httpclient.GetStringAsync(url);
            CaracteristicasPokemon caracteristicas = JsonConvert.DeserializeObject<CaracteristicasPokemon>(json);
            return caracteristicas; 
        }
    }
}
