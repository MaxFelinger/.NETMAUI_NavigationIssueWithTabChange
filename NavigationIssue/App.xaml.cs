namespace NavigationIssue;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();

        Routing.RegisterRoute(nameof(RegularPage), typeof(RegularPage));
        Routing.RegisterRoute(nameof(RegularPage2), typeof(RegularPage2));
        Routing.RegisterRoute(nameof(ModalPage), typeof(ModalPage));
    }
}