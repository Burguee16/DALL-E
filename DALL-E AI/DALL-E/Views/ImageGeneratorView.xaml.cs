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
	private async void StopGeneration()
	{
		await Task.Delay(2000);

		lottie.IsAnimationEnabled = false;
		lottie.IsVisible = false;
		ImageBorder.IsVisible = true;
		ImageAnimation.IsVisible = true;

		await Task.WhenAny(
			ImageAnimation.ScaleTo(1.1, 1000),
			ImageAnimation.FadeTo(0, 1000),
            borderTime.ScaleTo(1, 1000),
            borderTime.FadeTo(0, 1000)

            );

		await borderTime.FadeTo(0, 300);
		await btnFinish.ScaleTo(1, 1000);


	}
}