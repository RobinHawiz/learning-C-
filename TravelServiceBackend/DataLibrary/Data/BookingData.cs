using Dapper;
using DataLibrary.Db;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data;
public class BookingData
{
    private readonly IDataAccess _dataAccess;
    private readonly ConnectionStringData _connectionStringName;
    public BookingData(IDataAccess dataAccess, ConnectionStringData connectionStringName)
    {
        _dataAccess = dataAccess;
        _connectionStringName = connectionStringName;
    }
    public async Task<BookingModel> GetById(int id)
    {
        return (await _dataAccess.LoadData<BookingModel, object>("dbo.spBookings_GetById"
                                                              , new { id }
                                                              , _connectionStringName.SqlConnectionName))
                                                              .FirstOrDefault();
    }
    public async Task<List<BookingModel>> GetAllByUserId(int userId)
    {
        return await _dataAccess.LoadData<BookingModel, dynamic>("dbo.spBookings_GetAllByUserId"
                                                               , new { userId }
                                                               , _connectionStringName.SqlConnectionName);
    }
    public async Task<int> Insert(BookingModel booking)
    {
        DynamicParameters p = new DynamicParameters();
        p.Add("TransportationId", booking.TransportationId);
        p.Add("ZoneId", booking.ZoneId);
        p.Add("UserId", booking.UserId);
        p.Add("StartDate", booking.StartDate);
        p.Add("EndDate", booking.EndDate);
        p.Add("WheelChair", booking.WheelChair);
        p.Add("TotalCost", booking.TotalCost);
        p.Add("AddressFrom", booking.AddressFrom);
        p.Add("AddressTo", booking.AddressTo);
        p.Add("Id", DbType.Int32, direction: ParameterDirection.Output);

        await _dataAccess.SaveData("dbo.spBookings_Insert"
                                 , p
                                 , _connectionStringName.SqlConnectionName);

        return p.Get<int>("Id");
    }
    public async void UpdateAddress(int id, int zoneId, DateTime addressFrom, DateTime addressTo)
    {
        await _dataAccess.SaveData("dbo.spBookings_UpdateAddress"
                                 , new { Id = id, ZoneId = zoneId, AddressFrom = addressFrom, AddressTo = addressTo }
                                 , _connectionStringName.SqlConnectionName);
    }
    public async void Delete(int id)
    {
        await _dataAccess.SaveData("dbo.spBookings_Delete"
                                 , new { Id = id }
                                 , _connectionStringName.SqlConnectionName);
    }
}
