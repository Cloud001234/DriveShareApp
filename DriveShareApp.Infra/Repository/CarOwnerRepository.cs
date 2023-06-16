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
    public class CarOwnerRepository : ICarOwnerRepository
    {
        private readonly IDbContext dBContext;
        public CarOwnerRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public void acceptPassenger(Trippassengergp trippassengergp)
        {
            var p = new DynamicParameters();
            p.Add("TID", trippassengergp.Tripid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("PID", trippassengergp.Passengerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<Trippassengergp>("CAROWNERGP_PACKAGE.ACCEPTPASSENGER", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
        }

        public void activeCarOwner(CarOwnerDTO carOwnerDTO)
        {
            var p = new DynamicParameters();
            p.Add("PID", carOwnerDTO.Passengerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CT", carOwnerDTO.Cartype, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CM", carOwnerDTO.Carmodel, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CMM", carOwnerDTO.Carmmodel, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CN", carOwnerDTO.Carnumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGE", carOwnerDTO.Imageliecnse, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DL", carOwnerDTO.Drivelicense, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<CarOwnerDTO>("CAROWNERGP_PACKAGE.ACTIVECAROWNER", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
        }

        public void activeTrip(Tripgp tripgp)
        {
            var p = new DynamicParameters();
            p.Add("TID", tripgp.Tripid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<Tripgp>("CAROWNERGP_PACKAGE.ACTIVETRIP", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
        }
        public void finishTrip(Tripgp tripgp)
        {
            var p = new DynamicParameters();
            p.Add("TID", tripgp.Tripid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<Tripgp>("CAROWNERGP_PACKAGE.FINISHTRIP", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
        }
        public decimal checkCarOwner(Passengergp passengergp)
        {
            var p = new DynamicParameters();
            p.Add("PID", passengergp.Passengerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<decimal>("CAROWNERGP_PACKAGE.CHECKCAROWNER", p, commandType: CommandType.StoredProcedure).FirstOrDefault();
            dBContext.Connection.Dispose();

            return result;
        }

        public void createTrip(Tripgp tripgp)
        {
            var p = new DynamicParameters();
            p.Add("SP", tripgp.Startpoint, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EP", tripgp.Endpoint, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("RP", tripgp.Rideprice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("TT", tripgp.Triptime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("SN", tripgp.Seatnumber, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("DS", tripgp.Descreption, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IA", tripgp.Isactive, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CID", tripgp.Carownerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("SP11", tripgp.Sp1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SP22", tripgp.Sp3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SP33", tripgp.Sp3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SP44", tripgp.Sp4, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<Tripgp>("CAROWNERGP_PACKAGE.CREATETRIP", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
        }

        public void deleteCar(int id)
        {
            var p = new DynamicParameters();
            p.Add("PID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<CarOwnerDTO>("CAROWNERGP_PACKAGE.DELETECAR", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
        }

        public void deleteTrip(int id)
        {
            var p = new DynamicParameters();
            p.Add("TID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<Tripgp>("CAROWNERGP_PACKAGE.DELETETRIP", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
        }

        public List<TripPasengerDTO> getAllAccept(TripPasengerDTO tripPasengerDTO)
        {
            var p = new DynamicParameters();
            p.Add("TID", tripPasengerDTO.Tripid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<TripPasengerDTO> result = dBContext.Connection.Query<TripPasengerDTO>("CAROWNERGP_PACKAGE.GETALLACCEPT", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
            return result.ToList();
        }

        public List<Passengergp> getAllPassenger()
        {
            IEnumerable<Passengergp> result = dBContext.Connection.Query<Passengergp>("CAROWNERGP_PACKAGE.GETALLPASSENGER", commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
            return result.ToList();
        }

        public List<TripPasengerDTO> getAllRequest(TripPasengerDTO tripPasengerDTO)
        {
            var p = new DynamicParameters();
            p.Add("TID", tripPasengerDTO.Tripid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<TripPasengerDTO> result = dBContext.Connection.Query<TripPasengerDTO>("CAROWNERGP_PACKAGE.GETALLREQUEST", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
            return result.ToList();
        }

        public List<Tripgp> getAllTrip()
        {
            IEnumerable<Tripgp> result = dBContext.Connection.Query<Tripgp>("CAROWNERGP_PACKAGE.GETALLTRIP", commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
            return result.ToList();
        }

        public Passengergp getPassengerById(Passengergp passengergp)
        {
            var p = new DynamicParameters();
            p.Add("PID", passengergp.Passengerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<Passengergp>("CAROWNERGP_PACKAGE.GETPASSENGERBYID", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
            return result.FirstOrDefault();
        }

        public CarOwnerDTO getCar(CarOwnerDTO carOwnerDTO)
        {
            var p = new DynamicParameters();
            p.Add("COID", carOwnerDTO.Carownerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<CarOwnerDTO>("CAROWNERGP_PACKAGE.GETCAR", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
            return result.FirstOrDefault();

        }
        public TripPasengerDTO getRequestById(TripPasengerDTO tripPasengerDTO)
        {
            var p = new DynamicParameters();
            p.Add("TID", tripPasengerDTO.Tripid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("PID", tripPasengerDTO.Passengerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<TripPasengerDTO>("CAROWNERGP_PACKAGE.GETREQUESTBYID", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
            return result.FirstOrDefault();
        }

        public Tripgp getTripById(Tripgp tripgp)
        {
            var p = new DynamicParameters();
            p.Add("TID", tripgp.Tripid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<Tripgp>("CAROWNERGP_PACKAGE.GETTRIPBYID", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
            return result.FirstOrDefault();
        }

        public List<Tripgp> getTripCarOwner(Tripgp tripgp)
        {
            var p = new DynamicParameters();
            p.Add("COID", tripgp.Carownerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Tripgp> result = dBContext.Connection.Query<Tripgp>("CAROWNERGP_PACKAGE.GETTRIPSCAROWNER", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
            return result.ToList();
        }

        public void updateCar(CarOwnerDTO carOwnerDTO)
        {
            var p = new DynamicParameters();
            p.Add("PID", carOwnerDTO.Passengerid, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("CT", carOwnerDTO.Cartype, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CM", carOwnerDTO.Carmodel, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("CMM", carOwnerDTO.Carmmodel, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("CN", carOwnerDTO.Carnumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGE", carOwnerDTO.Imageliecnse, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DL", carOwnerDTO.Drivelicense, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<CarOwnerDTO>("CAROWNERGP_PACKAGE.UPDATECAR", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
        }

        public void updateTrip(Tripgp tripgp)
        {
            var p = new DynamicParameters();
            p.Add("TID", tripgp.Tripid, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("SP", tripgp.Startpoint, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EP", tripgp.Endpoint, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("RP", tripgp.Rideprice, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("TT", tripgp.Triptime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("SN", tripgp.Seatnumber, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("DS", tripgp.Descreption, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IA", tripgp.Isactive, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("CID", tripgp.Carownerid, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("SP11", tripgp.Sp1, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SP22", tripgp.Sp3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SP33", tripgp.Sp3, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("SP44", tripgp.Sp4, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<Tripgp>("CAROWNERGP_PACKAGE.UPDATETRIP", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
        }
        public Passengergp getCarowner(Passengergp passengergp)
        {
            var p = new DynamicParameters();
            p.Add("COID", passengergp.Carownerid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.Query<Passengergp>("CAROWNERGP_PACKAGE.GETCAROWNER", p, commandType: CommandType.StoredProcedure);
            dBContext.Connection.Dispose();
            return result.FirstOrDefault();

        }


    }
}
