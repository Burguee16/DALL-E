using DALL_E.Models;

namespace DALL_E.Views;

public partial class GenerationOptionsView : ContentPage
{
	public List<string> Options { get; set; }

    public List<ArtStyle> Styles { get; set; }


    public GenerationOptionsView()
	{
		InitializeComponent();
		FillOptions();
		BindingContext = this;
	}

	private void FillOptions()
	{
		Options = new List<string>
		{
			"Word",
			"Winter",
			"Tress"
		};
        Styles = new List<ArtStyle>()
		{
			new ArtStyle() { Name = "Dot Net", ImageUrl = "dotnet_bot.png" },
			new ArtStyle() { Name = "Henry", ImageUrl = "dotnet_bot.png" },
			new ArtStyle() { Name = "Mady", ImageUrl = "dotnet_bot.png" }
		};
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ImageGeneratorView());
    }
}