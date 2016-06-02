
using MVVM.Services;
using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVM.ViewModels

{
    public class MainViewModel : INotifyPropertyChanged 
    {
        private List<Employee> _employeeList;
        private Employee _selectedEmployee = new Employee();

        public List<Employee> EmployeeList
        {
            get { return _employeeList; }
            set
            {
                _employeeList = value;
                OnPropertyChanged();
            }
        }

        public Employee SelectedEmployee {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged();
            }
        }

        public Command PostComnand
        {
            get
            {
                return new Command(async () => 
                {
                    var employeesServices = new EmployeeServices();
                    await employeesServices.PostEmployeesAsync(_selectedEmployee);
                });
            }

        }

        public Command PutComnand
        {
            get
            {
                return new Command(async () =>
                {
                    var employeesServices = new EmployeeServices();
                    await employeesServices.PutEmployeesAsync(_selectedEmployee.Id, _selectedEmployee);
                });
            }

        }

        public Command DeleteComnand
        {
            get
            {
                return new Command(async () =>
                {
                    var employeesServices = new EmployeeServices();
                    await employeesServices.DeleteEmployeesAsync(_selectedEmployee.Id);
                });
            }

        }

        public MainViewModel()
        {

            InitializeDataAsync();
        }

        private async Task InitializeDataAsync()
        {
            var employeesServices = new EmployeeServices();
            EmployeeList = await employeesServices.GetEmployeesAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
