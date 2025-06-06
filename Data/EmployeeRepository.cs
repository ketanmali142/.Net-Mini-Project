using EMS_API.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS_API.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAll() =>
            await _context.Employee.Where(e => e.Salary > 25000).ToListAsync();

        public async Task<Employee?> GetById(int id) => await _context.Employee.FindAsync(id);

        public async Task<Employee> Add(Employee emp)
        {
            _context.Employee.Add(emp);
            await _context.SaveChangesAsync();
            return emp;
        }

        public async Task<Employee?> Update(int id, Employee emp)
        {
            var existing = await _context.Employee.FindAsync(id);
            if (existing == null) return null;

            existing.Name = emp.Name;
            existing.Department = emp.Department;
            existing.Email = emp.Email;
            existing.Salary = emp.Salary;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> Delete(int id)
        {
            var emp = await _context.Employee.FindAsync(id);
            if (emp == null) return false;

            _context.Employee.Remove(emp);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}