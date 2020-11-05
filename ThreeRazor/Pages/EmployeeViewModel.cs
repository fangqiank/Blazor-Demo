using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThreeRazor.Services;

namespace ThreeRazor.Pages
{
    public class EmployeeViewModel:ComponentBase
    {
        [Parameter]
        public string DepartmentId { get; set; }

        public IEnumerable<ThreeRazor.Models.Employee> Employees;

        [Inject]
        protected IEmployeeService EmployeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await EmployeeService.GetByDepartmentId(int.Parse(DepartmentId));
        }
    }
}
