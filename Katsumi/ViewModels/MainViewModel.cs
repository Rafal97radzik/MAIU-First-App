using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katsumi.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        int _count;

        [ICommand]
        private void IncrementCount()
        {
            Count++;
        }
    }
}
