using MvvmMaui.MVVM.Models;

namespace MvvmMaui.MVVM.ViewModels;

public class PersonViewModel
{
    public Person Person { get; set; }
    public PersonViewModel()
    {
        Person = new Person
        {
            Name = "Luis",
            Age = 38,
            Married = true,
            BirthDate = new DateTime(2010, 11, 01),
            Weight = 80,
            Lunchtime = new TimeSpan(14, 0, 0)
        };

    }
}