namespace TipCalculator.Views;

public partial class StyleDemoPage : ContentPage
{
	private const string sampleText = @"Lorem ipsum dolor sit amet. Qui nemo ipsa id suscipit aperiam cum velit alias eos excepturi dignissimos! Sit repudiandae rerum et inventore rerum rem ipsum officia qui totam rerum. Ut quas ducimus At consequatur debitis id vitae cupiditate et provident omnis eos quas et quisquam beatae eos nihil repellat.

Sed quae modi ad excepturi omnis in quaerat fugit non quia omnis aut odit deleniti nam error quaerat sed fugit esse. Ut recusandae excepturi non sapiente soluta non quidem magnam quo perspiciatis quia et nesciunt velit aut rerum rerum! Et voluptatem temporibus aut explicabo nulla eum quidem impedit aut ducimus cumque aut dolorem beatae est voluptas quos. ";

	private Color white = Colors.White;
	private Color black = Colors.Black;
	private Color dimGray = Colors.DimGray;
	private Color lightGray = Colors.LightGray;
	public StyleDemoPage()
	{
		InitializeComponent();

		sampleTextLabel.Text = sampleText;
	}

	private void OnDarkButton_Clicked(object sender, EventArgs e)
		=> UpdateColors(white, black, lightGray, dimGray);

	private void OnLightButton_Clicked(object sender, EventArgs e)
		=> UpdateColors(black, white, dimGray, lightGray);

	private void UpdateColors(Color foreground, Color background, Color buttonFg, Color buttonBg)
	{
		this.Resources["bgColor"] = background;
		this.Resources["fgColor"] = foreground;
		this.Resources["btnBgColor"] = buttonBg;
		this.Resources["btnFgColor"] = buttonFg;
	}

	private void OnMinusSizeButton_Clicked(object sender, EventArgs e)
	{
		var currentFontSize = (double)this.Resources["fontSize"];

		if (currentFontSize > 10) this.Resources["fontSize"] = currentFontSize - 1;
	}
	private void OnPlusSizeButton_Clicked(object sender, EventArgs e)
	{
		var currentFontSize = (double)this.Resources["fontSize"];

		if (currentFontSize < 20) this.Resources["fontSize"] = currentFontSize + 1;
	}
}