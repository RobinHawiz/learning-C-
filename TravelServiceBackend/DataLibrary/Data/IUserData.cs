using DataLibrary.Models;

namespace DataLibrary.Data
{
    public interface IUserData
    {
        Task<int> CheckByEmailAddress(string emailAddress);
        Task<UserModel> GetByEmailAddressAndPassword(string emailAddress, string password);
        void Insert(UserModel user);
    }
}