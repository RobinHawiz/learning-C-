using DataLibrary.Db;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data;
public class UserData
{
    private readonly IDataAccess _dataAccess;
    private readonly ConnectionStringData _connectionStringName;

    public UserData(IDataAccess DataAccess, ConnectionStringData ConnectionStringName)
    {
        _dataAccess = DataAccess;
        _connectionStringName = ConnectionStringName;
    }

    public async Task<UserModel> GetByEmailAddressAndPassword(string emailAddress, string password)
    {
        return (await _dataAccess.LoadData<UserModel, dynamic>("dbo.spUsers_GetByEmailAddressAndPassword"
                                                             , new { emailAddress, password }, _connectionStringName.SqlConnectionName))
                                                             .FirstOrDefault();
    }
    public async Task<int> CheckByEmailAddress(string emailAddress)
    {
        return (await _dataAccess.LoadData<int, dynamic>("dbo.spUsers_CheckByEmailAddress"
                                                            , new { emailAddress }
                                                            , _connectionStringName.SqlConnectionName))
                                                            .FirstOrDefault();
    }
    public async void Insert(UserModel user)
    {
        await _dataAccess.SaveData("dbo.spUsers_Insert", user, _connectionStringName.SqlConnectionName);
    }
}
