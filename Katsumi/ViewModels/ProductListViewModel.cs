using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Katsumi.Pages;

namespace Katsumi.ViewModels
{
    public partial class ProductListViewModel : ObservableObject
    {
        [ICommand]
        private void SwichPage(string parameter)
        {
            if (parameter == "back")
                Shell.Current.GoToAsync("..");

            if (parameter == "next")
                Shell.Current.GoToAsync("surprise");
        }

        [ICommand]
        private void SwichPage2(string parameter)
        {
            if (parameter == "back")
                Shell.Current.Navigation.PopAsync();

            if (parameter == "next")
                Shell.Current.Navigation.PushAsync(new SurprisePage());
        }
    }
}
