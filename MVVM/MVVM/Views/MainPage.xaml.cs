using MVVM.ViewModels;
using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MVVM.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewEmployeePage());
        }

        private async void ListView_OnItemTapped(Object sender, EventArgs e)
        {
            var employee = EmployeesList.SelectedItem as Employee;

            if (employee != null)
            {
                var mainViewModel = BindingContext as MainViewModel;

                if (mainViewModel != null)
                {
                    mainViewModel.SelectedEmployee = employee;

                    await Navigation.PushAsync(new NewEmployeePage(mainViewModel));
                }
            }
        }
    }
}
