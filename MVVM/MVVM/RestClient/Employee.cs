using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.RestClient
{
    /// <summary>
    /// Sample model to test the RestClient object 
    /// with the web service available on:
    /// http://intilaqemployees.azurewebsites.net/api/employeesapi/
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Department { get; set; }
    }
}
