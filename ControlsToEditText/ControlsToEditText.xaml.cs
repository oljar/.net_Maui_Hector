namespace ControlsToEditText;
using System.Diagnostics;
public partial class ControlsToEditText : ContentPage
{
	public ControlsToEditText()
	{
		InitializeComponent();
	}



    private void txtName_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void txtName_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine(txtName.Text);

    }

    private void txtDescription_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}