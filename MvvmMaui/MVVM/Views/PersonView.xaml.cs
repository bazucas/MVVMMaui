using MvvmMaui.MVVM.ViewModels;

namespace MvvmMaui.MVVM.Views;

public partial class PersonView : ContentPage
{
    public PersonView()
    {
        InitializeComponent();

        BindingContext = new PersonViewModel();
    }
}