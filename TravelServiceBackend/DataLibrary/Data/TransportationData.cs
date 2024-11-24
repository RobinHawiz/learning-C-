using DataLibrary.Db;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data;
public class TransportationData
{
    private readonly IDataAccess _dataAccess;
    private readonly ConnectionStringData _connectionStringName;

    public TransportationData(IDataAccess dataAccess, ConnectionStringData connectionStringName)
    {
        _dataAccess = dataAccess;
        _connectionStringName = connectionStringName;
    }
    public async Task<TransportationModel> GetById(int id)
    {
        return (await _dataAccess.LoadData<TransportationModel, dynamic>("dbo.spTransportations_GetById"
                                                             , new { Id = id }
                                                             , _connectionStringName.SqlConnectionName))
                                                             .First();
    }
    public async Task<List<TransportationModel>> GetAll()
    {
        return await _dataAccess.LoadData<TransportationModel, dynamic>("dbo.spTransportations_GetAll"
                                                            , new { }
                                                            , _connectionStringName.SqlConnectionName);
    }
}
