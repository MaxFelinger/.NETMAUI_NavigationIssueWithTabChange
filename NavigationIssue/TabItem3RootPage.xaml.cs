namespace NavigationIssue;

public partial class TabItem3RootPage : ContentPage
{
    public TabItem3RootPage()
    {
        InitializeComponent();
    }

    private async void Button_OnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(RegularPage));
    }
}