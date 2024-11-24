using DataLibrary.Db;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data;
public class ZoneData : IZoneData
{
    private readonly IDataAccess _dataAccess;
    private readonly ConnectionStringData _connectionStringName;

    public ZoneData(IDataAccess dataAccess, ConnectionStringData connectionStringName)
    {
        _dataAccess = dataAccess;
        _connectionStringName = connectionStringName;
    }
    public async Task<ZoneModel> GetById(int id)
    {
        return (await _dataAccess.LoadData<ZoneModel, dynamic>("dbo.spZones_GetById"
                                                             , new { Id = id }
                                                             , _connectionStringName.SqlConnectionName))
                                                             .First();
    }
    public async Task<List<ZoneModel>> GetAll()
    {
        return await _dataAccess.LoadData<ZoneModel, dynamic>("dbo.spZones_GetAll"
                                                            , new { }
                                                            , _connectionStringName.SqlConnectionName);
    }
}
