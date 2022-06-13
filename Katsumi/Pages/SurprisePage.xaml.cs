namespace Katsumi.Pages;

public partial class SurprisePage : ContentPage
{
	public SurprisePage()
	{
		InitializeComponent();
    }

    //Nie dzia³a
    private void ButtonGoBackClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    //Nie dzia³a
    private void ButtonGoBackV2Clicked(object sender, EventArgs e)
    {
        Shell.Current.Navigation.PopAsync();
    }
}