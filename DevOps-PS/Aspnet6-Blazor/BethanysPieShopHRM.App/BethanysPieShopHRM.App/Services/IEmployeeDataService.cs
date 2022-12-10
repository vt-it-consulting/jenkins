using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.App.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync(bool refreshRequired = false);
        Task<Employee> GetEmployeeDetailsAsync(int employeeId);
        Task<Employee> AddEmployeeAsync(Employee employee);
        Task UpdateEmployeeAsync(Employee employee);
        Task DeleteEmployeeAsync(int employeeId);
    }
}
