using MvvmMaui.MVVM.ViewModels;

namespace MvvmMaui.MVVM.Views;

public partial class PeopleView : ContentPage
{
    public PeopleView()
    {
        InitializeComponent();
        BindingContext = new PeopleViewModel();
    }
}