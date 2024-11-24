using DataLibrary.Models;

namespace DataLibrary.Data
{
    public interface IZoneData
    {
        Task<List<ZoneModel>> GetAll();
        Task<ZoneModel> GetById(int id);
    }
}