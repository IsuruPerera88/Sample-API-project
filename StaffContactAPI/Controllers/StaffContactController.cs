using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StaffContactAPI.Data;
using StaffContactAPI.Dto;
using StaffContactAPI.Repositories.Interfaces;

namespace StaffContactAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffContactController : ControllerBase
    {
        private IEmployee _employee;
        public StaffContactController(IEmployee employee)
        {
            _employee = employee;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            IEnumerable<ContactDetailDTO> contactDetailDTOs = _employee.GetAllEmployeeContactDetails();
            if (contactDetailDTOs == null)
            {
                return NotFound();
            }
            return Ok(contactDetailDTOs);
        }

        [HttpGet]
        [Route("GetManagerList")]
        public IActionResult GetManagerList()
        {
            IEnumerable<ContactDetailDTO> contactDetailDTOs = _employee.GetAllManagersContactDetails();
            if (contactDetailDTOs == null)
            {
                return NotFound();
            }
            return Ok(contactDetailDTOs);
        }

        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            ContactDetailDTO p = _employee.GetEmployeeById(id);
            if (p == null)
            {
                return NotFound();
            }
            return Ok(p);
        }

        [HttpPost]
        [Route("Creates")]
        public IActionResult Creates(ContactDetailDTO pt)
        {
            int rs = _employee.CreateEmployee(pt);
            if (rs <= 0)
            {
                return BadRequest("Failed");
            }
            else
                return Ok(rs);
        }

        [HttpPut]
        [Route("Edit")]
        public IActionResult Edit(ContactDetailDTO pt)
        {
            int rs = _employee.UpdateEmployee(pt);
            if (rs <= 0)
            {
                return BadRequest("Failed");
            }
            else
                return Ok("Updated! " + rs);
        }

        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            int rs = _employee.DeleteEmployee(id);
            if (rs <= 0)
            {
                return BadRequest("Failed");
            }
            else
                return Ok("Deleted! " + rs);
        }
    }
}
