using MvvmMaui.MVVM.Views;

namespace MvvmMaui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new PeopleView();
    }
}
