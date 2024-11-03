using Dapper;
using DataLibrary.Db;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace DataLibrary.Data;
public class OrderData : IOrderData
{
    private readonly IDataAccess _dataAccess;
    private readonly ConnectionStringData _connectionString;

    public OrderData(IDataAccess dataAccess, ConnectionStringData connectionString)
    {
        _dataAccess = dataAccess;
        _connectionString = connectionString;
    }

    public async Task<OrderModel> GetOrderById(int id)
    {
        var recs = await _dataAccess.LoadData<OrderModel, dynamic>("dbo.spOrder_GetById"
                                                       , new { id }
                                                       , _connectionString.SqlConnectionName);

        return recs.FirstOrDefault();
    }

    public async Task<int> CreateOrder(OrderModel order)
    {
        DynamicParameters p = new DynamicParameters();
        p.Add("OrderName", order.OrderName);
        p.Add("OrderDate", order.OrderDate);
        p.Add("FoodId", order.FoodId);
        p.Add("Quantity", order.Quantity);
        p.Add("Total", order.Total);
        p.Add("Id", DbType.Int32, direction: ParameterDirection.Output);

        await _dataAccess.SaveData("dbo.spOrder_Insert"
                                 , p
                                 , _connectionString.SqlConnectionName);
        return p.Get<int>("Id");
    }

    public Task<int> UpdateOrderName(int id, string orderName)
    {
        return _dataAccess.SaveData("dbo.spOrder_UpdateName"
                                  , new { id, orderName }
                                  , _connectionString.SqlConnectionName);
    }

    public Task<int> DeleteOrder(int id)
    {
        return _dataAccess.SaveData("dbo.spOrder_Delete"
                                  , new { id }
                                  , _connectionString.SqlConnectionName);
    }
}
