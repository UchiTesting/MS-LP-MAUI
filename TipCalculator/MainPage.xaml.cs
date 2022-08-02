﻿namespace TipCalculator;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnStack_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Stack");
    }

    private async void OnGrid_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Grid");
    }
}
