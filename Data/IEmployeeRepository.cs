using EMS_API.Models;

namespace EMS_API.Data
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee?> GetById(int id);
        Task<Employee> Add(Employee emp);
        Task<Employee?> Update(int id, Employee emp);
        Task<bool> Delete(int id);
    }
}