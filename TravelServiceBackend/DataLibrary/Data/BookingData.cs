using DataLibrary.Db;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
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
    public async Task<BookingModel> GetById(int userId)
    {
        return (await _dataAccess.LoadData<BookingModel, object>("dbo.spBookings_GetById"
                                                              , new { userId }
                                                              , _connectionStringName.SqlConnectionName))
                                                              .FirstOrDefault();
    }
}
