using HRM.ApplicationCore.Models;
using HRM.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly DepartmentRepository departmentRepository;

        public DepartmentController(DepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var departments = await departmentRepository.GetAllAsync();

            return Ok(departments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var department = await departmentRepository.GetAsync(id);

            if(department is null)
                return NotFound();

            return Ok(department);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Department department)
        {
            await departmentRepository.InsertAsync(department);
            return Created(nameof(Get), department.Id);
        }

        [HttpPut]
        public async Task<IActionResult>Put(Department department)
        {
            await departmentRepository.EditAsync(department);
            return Created(nameof(Get), department.Id); 
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult>Delete(int id )
        {
            var department = await departmentRepository.GetAsync(id);

            if (department is null)
                return NotFound();

            return Delete(department);
        }
    }
}
