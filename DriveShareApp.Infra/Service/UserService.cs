using DriveShareApp.Core.DTOs;
using DriveShareApp.Core.Repository;
using DriveShareApp.Core.Service;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
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

        public string userLogin(UserDTO userDTO)
        {
            var rusalt = UserRepository.userLogin(userDTO);

            if (rusalt == null)
            {
                var tokenKeyValue = new Dictionary<string, string>
                {
                    { "token", "0" }
                };

                string jsonResult = JsonConvert.SerializeObject(tokenKeyValue);
                return jsonResult;
            }
            else
            {
                // secret key
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                // signin credential
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                var clamis = new List<Claim>
                {
                  new Claim("Passengerid",rusalt.Passengerid.ToString()),
                  new Claim("carownerid",rusalt.Carownerid.ToString()),

                };
                // token options
                var tokenOptions = new JwtSecurityToken
                    (
                     claims: clamis,
                     expires: DateTime.Now.AddMonths(5),
                     signingCredentials: signinCredentials
                    );
                //convert token to string
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                var tokenKeyValue = new Dictionary<string, string>
                {
                    { "token", tokenString }
                };

                string jsonResult = JsonConvert.SerializeObject(tokenKeyValue);
                return jsonResult;

            }
        }

    }
}
