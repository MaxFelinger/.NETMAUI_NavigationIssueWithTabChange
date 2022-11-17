namespace NavigationIssue;

public partial class TabItem2RootPage : ContentPage
{
    public TabItem2RootPage()
    {
        InitializeComponent();
    }

    private async void ModalPageButton_OnClicked(object sender, EventArgs e)
    {
        // This fixes the tab selection.
        // await Shell.Current.GoToAsync("//TabBar/Tab.Item3");

        // When wi only have this one GoToAsync invocation, the target tab will not be selected.
        await Shell.Current.GoToAsync("//TabBar/Tab.Item3/" + nameof(ModalPage));
    }

    private async void RegularPageButton_OnClicked(object sender, EventArgs e)
    {
        // This fixes the tab selection.
        // await Shell.Current.GoToAsync("//TabBar/Tab.Item3");

        // When wi only have this one GoToAsync invocation, the target tab will not be selected.
        await Shell.Current.GoToAsync("//TabBar/Tab.Item3/" + nameof(RegularPage2));
    }
}