using DriveShareApp.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveShareApp.Core.Service
{
    public interface IUserService
    {
        void createUser(UserDTO userDTO);
        void updateUser(UserDTO userDTO);
        void deleteUser(int id);
        string userLogin(UserDTO userDTO);
        void updatepass(UserDTO userDTO);

    }
}
