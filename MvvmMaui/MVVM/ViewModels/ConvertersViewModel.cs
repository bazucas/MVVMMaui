using MvvmMaui.MVVM.Models;

namespace MvvmMaui.MVVM.ViewModels;

public class ConvertersViewModel
{
    public Data Data { get; set; }
    public ConvertersViewModel()
    {
        Data = new Data
        {
            Married = "YES"
        };
    }
}