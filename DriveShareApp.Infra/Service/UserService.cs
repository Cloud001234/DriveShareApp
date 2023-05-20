using DriveShareApp.Core.DTOs;
using DriveShareApp.Core.Repository;
using DriveShareApp.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveShareApp.Infra.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository UserRepository;

        public UserService(IUserRepository UserRepository)
        {
            this.UserRepository = UserRepository;
        }
        public void createUser(UserDTO userDTO)
        {
            UserRepository.createUser(userDTO);
        }

        public void deleteUser(int id)
        {
            UserRepository.deleteUser(id);
        }

        public void updateUser(UserDTO userDTO)
        {
            UserRepository.updateUser(userDTO);
        }

        public UserDTO userLogin(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
