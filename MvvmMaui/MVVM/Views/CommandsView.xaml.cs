using MvvmMaui.MVVM.ViewModels;

namespace MvvmMaui.MVVM.Views;

public partial class CommandsView : ContentPage
{
    public CommandsView()
    {
        InitializeComponent();
        BindingContext = new CommandsViewModel();
    }
}