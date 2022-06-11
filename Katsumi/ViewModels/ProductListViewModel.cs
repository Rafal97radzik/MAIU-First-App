using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Katsumi.Models;
using Katsumi.Pages;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Reflection;

namespace Katsumi.ViewModels
{
    public partial class ProductListViewModel : ObservableObject
    {
        public ObservableCollection<Product> Products { get; }

        public ProductListViewModel()
        {
            using var stream = FileSystem
                .OpenAppPackageFileAsync("Products.json")
                .GetAwaiter()
                .GetResult();

            using var reader = new StreamReader(stream);

            var contents = reader.ReadToEnd();

            Products = JsonConvert.DeserializeObject<ObservableCollection<Product>>(contents);
        }

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
