using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Form1ViewModel
    {
        public EmployeeRepository EmployeeRepository { get; }

        public Form1ViewModel()
        {
            EmployeeRepository = new EmployeeRepository();
        }
        public BindingList<Employee> LoadEmployees()
        {
            return EmployeeRepository.LoadEmployes();
        }
        public DataSet LoadPersons()
        {
            return EmployeeRepository.LoadPersons();
        }
        public DataSet FilterPersons(string pattern)
        {
            return EmployeeRepository.Filtername(pattern);
        }
    }
}
