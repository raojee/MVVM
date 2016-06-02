
using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Services
{
    public class EmployeeServices
    {
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            RestClient<Employee> restClient = new RestClient<Employee>();

            var employeesList = await restClient.GetAsync();

            return employeesList;
        }

        public async Task PostEmployeesAsync(Employee employee)
        {
            RestClient<Employee> restClient = new RestClient<Employee>();

            var employeesList = await restClient.PostAsync(employee);

            //return employeesList;
        }

        public async Task PutEmployeesAsync(int id, Employee employee)
        {
            RestClient<Employee> restClient = new RestClient<Employee>();

            var employeesList = await restClient.PutAsync(id,employee);

            //return employeesList;
        }

        public async Task DeleteEmployeesAsync(int id)
        {
            RestClient<Employee> restClient = new RestClient<Employee>();

            var employeesList = await restClient.DeleteAsync(id);

            //return employeesList;
        }
    }
}
