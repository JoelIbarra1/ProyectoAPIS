using ProyectoAPIS.Models;
using ProyectoAPIS.Servicios;

namespace ProyectoAPIS;

public partial class ResumenPokemon : ContentPage
{
	CaracteristicasPokemon caracteristicas = new CaracteristicasPokemon();
	public ResumenPokemon(string url)
	{
		InitializeComponent();
		CargaPokemon(url);

	}
	public async void CargaPokemon(string url)
	{
		PokemonAPI pokeServices = new PokemonAPI();
		caracteristicas = await pokeServices.DevuelveCaracteristicasPokemon(url);
		ImagePokemon.Source = caracteristicas.sprites.front_default;
		string habilidades = "";
		foreach (var ability in caracteristicas.abilities)
		{
			habilidades +=ability.ability.name+"  /  ";
		}
		Habilidades.Text = habilidades;
	}
}