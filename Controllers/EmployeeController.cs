using Microsoft.AspNetCore.Mvc;
using EMS_API.Data;
using EMS_API.Models;

namespace EMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repo;

        public EmployeeController(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _repo.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _repo.GetById(id));

        [HttpPost]
        public async Task<IActionResult> Create(Employee emp) => Ok(await _repo.Add(emp));

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Employee emp) => Ok(await _repo.Update(id, emp));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) => Ok(await _repo.Delete(id));
    }
}