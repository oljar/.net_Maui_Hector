namespace ControlsInput;

public partial class ControlsInput : ContentPage
{
    public ControlsInput()
    {
        InitializeComponent();
    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Clicked", $"Changed:{e.Value}", "OK");

    }

    private void sliderControl_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lblSlider.Text = SliderControl.Value.ToString("0.00");
    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (lblSlider != null)
        {
            lblSlider.Text = Stepper.Value.ToString("0.00");
        }

    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        DisplayAlert("Clicked", $"Changed:{e.Value}", "OK");
    }

    private void DatePickerControl_DateSelected(object sender, DateChangedEventArgs e)
    {
        DisplayAlert("Clicked", $"Changed:{e.NewDate}", "OK");

    }

    private void TimePickerControl_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {

        {
            if (e.PropertyName == nameof(TimePicker.Time))
            {
                var picker = (TimePicker)sender; var newTime = picker.Time; // Twoja logika po zmianie czasu }
                DisplayAlert("Clicked", $"Changed:{newTime}", "OK");
            }
        }
    }
}