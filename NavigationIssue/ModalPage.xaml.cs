namespace NavigationIssue;

public partial class ModalPage : ContentPage
{
    public ModalPage()
    {
        InitializeComponent();
    }

    private async void Button_OnClicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopModalAsync();
    }
}