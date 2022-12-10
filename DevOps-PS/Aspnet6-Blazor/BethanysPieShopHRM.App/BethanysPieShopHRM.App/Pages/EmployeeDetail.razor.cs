using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeDetail
    {

        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }


        [Parameter]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();

        protected override async  Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetailsAsync(EmployeeId); 
        }
    }
}
