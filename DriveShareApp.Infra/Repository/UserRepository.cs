using Dapper;
using DriveShareApp.Core.Common;
using DriveShareApp.Core.DTOs;
using DriveShareApp.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DriveShareApp.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbContext dBContext;
        public UserRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public void createUser(UserDTO userDTO)
        {
            var p = new DynamicParameters();
            p.Add("fname", userDTO.Fname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("LNAME", userDTO.Lname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("PHONENUMBER", userDTO.Phonenumber, dbType: DbType.String, ParameterDirection.Input);
            p.Add("USERNAME", userDTO.Username, dbType: DbType.String, ParameterDirection.Input);
            p.Add("IMAGEFILE", userDTO.Imagefile, dbType: DbType.String, ParameterDirection.Input);
            p.Add("gen", userDTO.Gender, dbType: DbType.String, ParameterDirection.Input);
            p.Add("useremail", userDTO.Email, dbType: DbType.String, ParameterDirection.Input);
            p.Add("userpass", userDTO.Password, dbType: DbType.String, ParameterDirection.Input);
            var result = dBContext.Connection.Query<UserDTO>("USERGP_PACKAGE.CREATEUSER", p, commandType: CommandType.StoredProcedure);
            

        }

        public void deleteUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("id",id, dbType: DbType.Int32, ParameterDirection.Input);
            var result = dBContext.Connection.Query<UserDTO>("USERGP_PACKAGE.deleteuser", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
        }

        public void updateUser(UserDTO userDTO)
        {
            var p = new DynamicParameters();
            p.Add("id", userDTO.Passengerid, dbType: DbType.Decimal, ParameterDirection.Input);
            p.Add("fn", userDTO.Fname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("lnn", userDTO.Lname, dbType: DbType.String, ParameterDirection.Input);
            p.Add("ph", userDTO.Phonenumber, dbType: DbType.String, ParameterDirection.Input);
            p.Add("us", userDTO.Username, dbType: DbType.String, ParameterDirection.Input);
            p.Add("image", userDTO.Imagefile, dbType: DbType.String, ParameterDirection.Input);
            p.Add("useremail", userDTO.Email, dbType: DbType.String, ParameterDirection.Input);
            p.Add("userpass", userDTO.Password, dbType: DbType.String, ParameterDirection.Input);
            var result = dBContext.Connection.Query<UserDTO>("USERGP_PACKAGE.updateuser", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
        }

        public UserDTO userLogin(UserDTO userDTO)
        {
            var p = new DynamicParameters();
            p.Add("useremail", userDTO.Email, dbType: DbType.String, ParameterDirection.Input);
            p.Add("userpass", userDTO.Password, dbType: DbType.String, ParameterDirection.Input);
            IEnumerable<UserDTO> result = dBContext.Connection.Query<UserDTO>("USERGP_PACKAGE.userlogin", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();

            return result.SingleOrDefault();
        }
    }
}
