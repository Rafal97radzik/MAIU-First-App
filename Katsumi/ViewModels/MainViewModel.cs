using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Katsumi.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsumi.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly ProductListPage productListPage;

        [ObservableProperty]
        private int _count;

        public MainViewModel(ProductListPage productListPage)
        {
            this.productListPage = productListPage;
        }

        [ICommand]
        private void IncrementCount()
        {
            Count++;
        }

        [ICommand]
        private void SwichPage()
        {
            Shell.Current.GoToAsync("productList");
        }

        [ICommand]
        private void SwichPage2()
        {
            Shell.Current.Navigation.PushAsync(productListPage);
        }
    }
}
