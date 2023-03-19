using MvvmMaui.MVVM.ViewModels;

namespace MvvmMaui.MVVM.Views;

public partial class ConvertersView : ContentPage
{
    public ConvertersView()
    {
        InitializeComponent();
        BindingContext = new ConvertersViewModel();
    }
}