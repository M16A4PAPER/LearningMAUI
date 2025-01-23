namespace ViewsDemo.Views;

public partial class CodeBindingPage : ContentPage
{
	public CodeBindingPage()
	{
		InitializeComponent();

		MyLabel.BindingContext = MySlider;

        MyLabel.SetBinding(Label.RotationProperty, "Value");
        MyLabel.SetBinding(Label.TextProperty, "Value", BindingMode.Default, null, "{0:F2}°");

        var MauiReleaseDate = new DateOnly(2022, 05, 23);
        DayName.SetBinding(Label.TextProperty, new Binding("DayOfWeek", source: MauiReleaseDate));
    }
}