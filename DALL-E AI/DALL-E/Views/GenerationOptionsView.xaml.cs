namespace DALL_E.Views;

public partial class GenerationOptionsView : ContentPage
{
	public List<string> Options { get; set; }
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
	}
}