using Dapper;
using DriveShareApp.Core.Common;
using DriveShareApp.Core.Data;
using DriveShareApp.Core.DTOs;
using DriveShareApp.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DriveShareApp.Infra.Repository
{
	public class PassengerRepository : IPassengerRepository
	{
        private readonly IDbContext dBContext;
        public CarOwnerRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

	

		void DeleteRating(int id)
        {
			var parameter = new DynamicParameters();
			parameter.Add("id", Rategp.rateid,)
		 p.Add("PID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
			var result = dBContext.Connection.Query<CarOwnerDTO>("CAROWNERGP_PACKAGE.DELETECAR", p, commandType: CommandType.StoredProcedure);
			dBContext.Connection.Dispose();
		}

		void CreateRating(Rategp rategp);

		Tripgp GetTripByid(int id);

		Tripgp Search_A_Trip_by_Location(Tripgp tripgp);

		Tripgp Search_A_Trip_by_Price(Tripgp tripgp);

		Tripgp Search_A_Trip_by_Date(Tripgp tripgp);

		PassengerDTO Request_A_Trip(PassengerDTO passengerDTO);

		bool Is_Start(PassengerDTO passengerDTO);	
		
		List<Tripgp> GetAllTrip();



	}



}
