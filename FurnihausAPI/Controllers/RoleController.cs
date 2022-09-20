using Business.Abstract;
using Core.Entity.Models;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FurnihausAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleManager _roleManager;

        public RoleController(IRoleManager roleManager)
        {
            _roleManager = roleManager;
        }

        [HttpGet("getall")]
        public IActionResult GetAllRoles()
        {
            var roles = _roleManager.GetAllRoles(); 
            if (roles.Count == 0)
                return Ok(new { status = 200, message = "Hec bir role tapilmadi" });
            return Ok(new { status = 200, message = roles });
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var role = _roleManager.GetRoleById(id);

            return Ok(new { status = 200, message = role });
        }

        [HttpPost("add")]
        public IActionResult AddRole(AddRoleDTO roleDTO)
        {
            try
            {
                _roleManager.AddRole(roleDTO);
            }
            catch (Exception e)
            {
                return Ok(new { status = 400, message = e });
            }

            return Ok(new { status = 200, message = "Role elave olundu." });
        }

        [HttpPut("update")]
        public IActionResult UpdateRole(Role role)
        {
            _roleManager.Update(role);
            return Ok(new { status = 200, message = role });
        }

        [HttpDelete("remove")]
        public IActionResult DeleteRole(Role role)
        {
            _roleManager.Remove(role);
            return Ok("Role ugurla silindi.");
        }


    }

}
