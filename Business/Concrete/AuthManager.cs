using Business.Abstract;
using Core.Entity.Models;
using Core.Security.Hasing;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthManager
    {
        private readonly IAuthDal _authDal;
        private readonly HasingHandler _hasingHandler;
        private readonly IUserRoleManager _userRoleManager;

        public AuthManager(IAuthDal authDal, HasingHandler hasingHandler, IUserRoleManager userRoleManager)
        {
            _authDal = authDal;
            _hasingHandler = hasingHandler;
            _userRoleManager = userRoleManager;
        }

        public User Login(string email)
        {
            var user = _authDal.Get(x => x.Email == email);
            if (user == null)
                return null;

            return user;
        }

        public List<User> GetUsers()
        {
            return _authDal.GetAll();
        }

        public void Register(RegisterDTO model)
        {
            User user = new()
            {
                Email = model.Email,
                FullName = model.FullName,
                Password = _hasingHandler.PasswordHash(model.Password),
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
            };
            _authDal.Add(user);
            var currentUser = _authDal.Get(x => x.Email == user.Email);
            _userRoleManager.AddDefaultRole(currentUser.Id);
        }

        public User GetUserByEmail(string email)
        {
            return _authDal.Get(x => x.Email == email);
        }
    
    }
}
