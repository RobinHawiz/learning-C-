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

    public async Task<UserModel> GetByEmailAddressAndPassword(string EmailAddress, string Password)
    {
        return (await _dataAccess.LoadData<dynamic, UserModel>("dbo.spUsers_GetByEmailAddressAndPassword"
                                                             , new { emailAddress = EmailAddress, password = Password }, _connectionStringName.SqlConnectionName))
                                                             .FirstOrDefault();
    }
}
