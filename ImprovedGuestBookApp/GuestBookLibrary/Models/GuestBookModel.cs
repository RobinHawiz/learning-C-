using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary.Models
{
    public class GuestBookModel
    {
        private List<GuestModel> _listOfGuests = new List<GuestModel>();
        public int TotalGuests { get; private set; }

        public void AddGuest(GuestModel guest) { _listOfGuests.Add(guest); TotalGuests += guest.partyAmount; }
        public List<GuestModel> GetGuestList()
        {
            // We do not allow the user to modify _listOfGuests inside the instantiated object with .Add by sending a copy of the list instead.
            // We essentially force the user to call the AddGuest method to add a GuestModel to _listOfGuests, instead of the built in method Add.
            List<GuestModel> list = new List<GuestModel>(_listOfGuests);
            return list;
        }
    }
}
