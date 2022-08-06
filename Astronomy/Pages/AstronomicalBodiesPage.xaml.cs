namespace Astronomy.Pages;

public partial class AstronomicalBodiesPage : ContentPage
{
	public AstronomicalBodiesPage()
	{
		InitializeComponent();

		btnComet.Clicked += async (source, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=comet");
		btnEarth.Clicked += async (source, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=earth");
		btnMoon.Clicked += async (source, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=moon");
		btnSun.Clicked += async (source, e) => await Shell.Current.GoToAsync("astronomicalbodydetails?astroName=sun");
	}
}