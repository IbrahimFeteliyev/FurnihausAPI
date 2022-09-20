using Business.Abstract;
using Core.Entity.Models;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RoleManager : IRoleManager
    {
        private readonly IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void AddRole(AddRoleDTO addRoleDTO)
        {
            Role role = new()
            { 
                Name = addRoleDTO.Name,
            };

            _roleDal.Add(role);
        }

        public List<Role> GetAllRoles()
        {
            return _roleDal.GetAll();
        }

        public Role GetRole(int userId)
        {
            return _roleDal.GetUserRole(userId);
        }

        public Role GetRoleById(int id)
        {
            return _roleDal.Get(x => x.Id == id);
        }

        public void Remove(Role role)
        {
            _roleDal.Delete(role);
        }

        public void Update(Role role)
        {
            _roleDal.Update(role);
        }
    }
}
