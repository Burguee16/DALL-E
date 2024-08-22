namespace DALL_E.Views;

public partial class ImageGeneratorView : ContentPage
{
	public ImageGeneratorView()
	{
		InitializeComponent();
	}

    private void btnFinish_Clicked(object sender, EventArgs e)
    {
		StopGeneration();
    }
	private void StopGeneration()
	{
		lottie.IsAnimationEnabled = false;
		lottie.IsVisible = false;
		ImageBorder.IsVisible = true;
	}
}