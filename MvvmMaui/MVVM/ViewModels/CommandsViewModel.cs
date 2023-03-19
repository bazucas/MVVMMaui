using System.Windows.Input;

namespace MvvmMaui.MVVM.ViewModels;

public class CommandsViewModel
{
    public ICommand ClickCommand { get; }
    public ICommand SearchCommand { get; }
    public string SearchTerm { get; set; }

    public CommandsViewModel()
    {
        ClickCommand = new Command(() =>
        {
            App.Current.MainPage
                .DisplayAlert("Title", "message", "Ok");
        });
        SearchCommand = new Command((s) =>
        {
            var data = s;
        });
    }

    private void Alert()
    {

    }
}