namespace ViewsDemo.Views;

public partial class ActivityPage : ContentPage
{
    double progress = 0.0;
    public ActivityPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        activityIndicator.IsRunning = !activityIndicator.IsRunning;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        progress += 0.20;

        if (progress >= 1.0)
        {
            progress = 0.0;
        }

        progressBar.Progress = progress;
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        progress += 0.20;

        if (progress >= 1.0)
        {
            progress = 0.0;
        }

        await progressBar.ProgressTo(progress, 500, Easing.Linear);
    }
}