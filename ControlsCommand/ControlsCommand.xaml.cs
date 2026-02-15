namespace ControlsCommand;

public partial class ControlsCommand : ContentPage
{
	public ControlsCommand()
	{
		InitializeComponent();
	}

    private void CounterBtn_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Clicked", "You clicked the button!", "OK");
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Clicked", "You clicked the button!", "OK");

    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Clicked", $"Changed:{e.Value}", "OK");

    }

    private void RadioButton_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Clicked", $"Changed:{e.Value}", "OK");

    }

    private void RadioButton_CheckedChanged_2(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Clicked", $"Changed:{e.Value}", "OK");

    }

    private void RadioButton_CheckedChanged_3(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Clicked", $"Changed:{e.Value}", "OK");

    }

    private void searchControl_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Searching", $"Searching:{searchControl.Text}", "OK");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("SwipeView", $"Element Tapped", "OK");
    }
}