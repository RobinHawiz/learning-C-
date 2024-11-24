using DataLibrary.Models;

namespace DataLibrary.Data
{
    public interface ITransportationData
    {
        Task<List<TransportationModel>> GetAll();
        Task<TransportationModel> GetById(int id);
    }
}