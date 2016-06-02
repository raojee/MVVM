using MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MVVM.Views
{
    public partial class NewEmployeePage : ContentPage
    {
        public NewEmployeePage()
        {
            InitializeComponent();
        }

        public NewEmployeePage(MainViewModel mainViewModel)
        {
            InitializeComponent();

            BindingContext = mainViewModel;
        }

    }
}
