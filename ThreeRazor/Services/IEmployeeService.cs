﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ThreeRazor.Models;

namespace ThreeRazor.Services
{
    public interface IEmployeeService
    {
        Task Add(Employee employee);
        Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId);
        Task<Employee> Fire(int id);
    }
}
