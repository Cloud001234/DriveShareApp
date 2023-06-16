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
        public PassengerRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public List<PassengerTripCar> GetAllTrip()
        {
			IEnumerable<PassengerTripCar> result = dBContext.Connection.Query<PassengerTripCar>("PASSENGER_PACKAGE.GETALLTRIP", commandType: CommandType.StoredProcedure);
			dBContext.Connection.Dispose();
			return result.ToList();
		}

		public void DeleteRating(int id)
        {
			var parameter = new DynamicParameters();
			parameter.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
			var result = dBContext.Connection.Query<Rategp>("PASSENGER_PACKAGE.DELETERATING", parameter, commandType: CommandType.StoredProcedure);
			dBContext.Connection.Dispose();
		}

		public void CreateRating(Rategp rategp)
        {
			var parameter = new DynamicParameters();
			parameter.Add("ratenum", rategp.Ratenumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
			parameter.Add("ratedes", rategp.Ratedesc, dbType: DbType.Int32, direction: ParameterDirection.Input);
			var result = dBContext.Connection.Query<Rategp>("PASSENGER_PACKAGE.CREATINGRATING", parameter, commandType: CommandType.StoredProcedure);
			dBContext.Connection.Dispose();
		}

		public Tripgp GetTripByid(int id)
        {
			var parameter = new DynamicParameters();
			parameter.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
			var result = dBContext.Connection.Query<Tripgp>("PASSENGER_PACKAGE.GETTRIPBYID", parameter, commandType: CommandType.StoredProcedure);
			dBContext.Connection.Dispose();
			return result.FirstOrDefault();
		}

		public List<PassengerTripCar> Search_A_Trip_by_Location(PassengerTripCar tripgp)
        {
			var parameter = new DynamicParameters();
			parameter.Add("startP", tripgp.Startpoint, dbType: DbType.String, direction: ParameterDirection.Input);
			parameter.Add("endP", tripgp.Endpoint, dbType: DbType.String, direction: ParameterDirection.Input);
			IEnumerable<PassengerTripCar> result = dBContext.Connection.Query<PassengerTripCar>("PASSENGER_PACKAGE.Search_A_Trip_by_Location", parameter, commandType: CommandType.StoredProcedure);
			dBContext.Connection.Dispose();
			return result.ToList();
		}

		public List<Tripgp> Search_A_Trip_by_Price(Tripgp tripgp)
        {
			var parameter = new DynamicParameters();
			parameter.Add("startP", tripgp.Startpoint, dbType: DbType.String, direction: ParameterDirection.Input);
			parameter.Add("endP", tripgp.Endpoint, dbType: DbType.String, direction: ParameterDirection.Input);
			parameter.Add("pir", tripgp.Rideprice, dbType: DbType.Double, direction: ParameterDirection.Input);
			IEnumerable<Tripgp> result = dBContext.Connection.Query<Tripgp>("PASSENGER_PACKAGE.Search_A_Trip_by_Price", parameter, commandType: CommandType.StoredProcedure);
			dBContext.Connection.Dispose();
			return result.ToList();
		}

		public List<Tripgp> Search_A_Trip_by_Date(Tripgp tripgp)
        {
			var parameter = new DynamicParameters();
			parameter.Add("startP", tripgp.Startpoint, dbType: DbType.String, direction: ParameterDirection.Input);
			parameter.Add("endP", tripgp.Endpoint, dbType: DbType.String, direction: ParameterDirection.Input);
			parameter.Add("da", tripgp.Triptime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
			IEnumerable<Tripgp> result = dBContext.Connection.Query<Tripgp>("PASSENGER_PACKAGE.Search_A_Trip_by_Date", parameter, commandType: CommandType.StoredProcedure);
			dBContext.Connection.Dispose();
			return result.ToList();
		}

		public void Request_A_Trip(PassengerDTO passengerDTO)
        {
			var parameter = new DynamicParameters();
			parameter.Add("TTripid", passengerDTO.Tripid, dbType: DbType.Int32, direction: ParameterDirection.Input);
			parameter.Add("passid", passengerDTO.Passengerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
			var result = dBContext.Connection.Query<PassengerDTO>("PASSENGER_PACKAGE.REQUEST_A_TRIP", parameter, commandType: CommandType.StoredProcedure);
			dBContext.Connection.Dispose();
		}

		public void Is_Start(PassengerDTO passengerDTO)
        {
			var parameter = new DynamicParameters();
			parameter.Add("TTripid", passengerDTO.Tripid, dbType: DbType.Int32, direction: ParameterDirection.Input);
			parameter.Add("passid", passengerDTO.Passengerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
			var result = dBContext.Connection.Query<PassengerDTO>("PASSENGER_PACKAGE.IS_START", parameter, commandType: CommandType.StoredProcedure);
			dBContext.Connection.Dispose();
		}
		public void Is_Finish(PassengerDTO passengerDTO)
		{
			var parameter = new DynamicParameters();
			parameter.Add("TTripid", passengerDTO.Tripid, dbType: DbType.Int32, direction: ParameterDirection.Input);
			parameter.Add("passid", passengerDTO.Passengerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
			var result = dBContext.Connection.Query<PassengerDTO>("PASSENGER_PACKAGE.Is_FINISH", parameter, commandType: CommandType.StoredProcedure);
			dBContext.Connection.Dispose();
		}
		public List<TripPassengerGPDTO> MyTrip(TripPassengerGPDTO tripPassengerGPDTO)
		{
			var p = new DynamicParameters();
			p.Add("PID", tripPassengerGPDTO.Passengerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
			IEnumerable<TripPassengerGPDTO> result = dBContext.Connection.Query<TripPassengerGPDTO>("PASSENGER_PACKAGE.MYTRIP", p, commandType: CommandType.StoredProcedure);
			dBContext.Connection.Dispose();
			return result.ToList();
		}

	}



}
