using DataLibrary.Models;

namespace DataLibrary.Data
{
    public interface IBookingData
    {
        void Delete(int id);
        Task<List<BookingModel>> GetAllByUserId(int userId);
        Task<BookingModel> GetById(int id);
        Task<int> Insert(BookingModel booking);
        void UpdateAddress(int id, int zoneId, DateTime addressFrom, DateTime addressTo);
    }
}