﻿using DriveShareApp.Core.DTOs;
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
        UserDTO userLogin(UserDTO userDTO);
    }
}