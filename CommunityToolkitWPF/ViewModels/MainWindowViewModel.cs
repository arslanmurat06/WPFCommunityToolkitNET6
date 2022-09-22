using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommunityToolkitWPF.ViewModels
{
    [ObservableObject]
    public partial class MainWindowViewModel
    {

        [ObservableProperty]
        public string? firstName = "Kemal";


        [RelayCommand]
        public void ClickMe()
        {
            FirstName = "Hasan";
        }
    } 
}
