using Core.Entity.Models;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRoleManager
    {
        void AddRole(AddRoleDTO addRoleDTO);
        void Remove(Role role);
        void Update(Role role); 
        List<Role> GetAllRoles();
        Role GetRole(int userId);
        Role GetRoleById(int id);

    }
}
