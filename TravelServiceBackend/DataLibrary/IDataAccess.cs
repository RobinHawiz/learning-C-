
namespace DataLibrary
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<U, T>(string storedProcedure, U parameters, string connectionStringName);
        Task<int> SaveData<U>(string storedProcedure, U parameter, string connectionStringName);
    }
}