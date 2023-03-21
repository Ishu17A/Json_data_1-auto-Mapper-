using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Newtonsoft.Json;
using static Json_data_1.Class2;

namespace Json_data_1
{

    internal class Program
    {
        static void Main(string[] args)
        {            
            Employee employee = new Employee { Name = "ishan",
                                Salary = 20000,
                                Address = "london",
                                Department = "it" };
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Employee, EmployeeDTO>());                
            var mapper = new Mapper(config);
            var x = mapper.Map<Employee, EmployeeDTO>(employee);
            Console.WriteLine("Name: " + x.Name + ", Salary: " + x.Salary + ", Address: " + x.Address + ", Department: " + x.Department);
            Console.ReadLine();

        }
    }
}
