using ProyectoAPIS.Models;
using ProyectoAPIS.Servicios;

namespace ProyectoAPIS;

public partial class ListadoPokemon : ContentPage
{
	public List<PokemonInfo> listado_pokemon;
	public ListadoPokemon()
	{

		InitializeComponent();

    }
	public async void LoadData()
	{
		PokemonAPI pokeapi = new PokemonAPI();
        listado_pokemon = await pokeapi.DevuelveListadoPokemon();
		PokemonList.ItemsSource = listado_pokemon;
	}

	public void MuestraResumenPokemon(object sender , SelectedItemChangedEventArgs e)
	{
		PokemonInfo pokeinfo = (PokemonInfo)e.SelectedItem;

		Navigation.PushAsync(new ResumenPokemon(pokeinfo.url));
	}
}