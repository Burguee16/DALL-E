using System.Diagnostics;

namespace DALL_E.Views;

public partial class ImageGeneratorView : ContentPage
{
	Stopwatch watch = new Stopwatch();
	public ImageGeneratorView()
	{
		InitializeComponent();
	}
	protected override async void OnAppearing()
	{
		await Task.Delay(TimeSpan.FromSeconds(2));
		watch.Start();

		var cts = new CancellationTokenSource();

		using (var timer = new PeriodicTimer(TimeSpan.FromSeconds(1)))
		{
			try
			{
				var counter = 0;
				while (await timer.WaitForNextTickAsync(cts.Token))
				{
					if (counter == 5)
					{
						cts.Cancel();
					}
					var seconds = watch.Elapsed.Seconds;
					lblTimer.Text = seconds.ToString();
					counter++;

				}

			}
			catch (TaskCanceledException)
			{

				await StopGeneration();
			}
		}

	}
    private void btnFinish_Clicked(object sender, EventArgs e)
    {
		StopGeneration();
    }
	private async Task StopGeneration()
	{
		watch.Stop();

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

    private async void btnFinish_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}