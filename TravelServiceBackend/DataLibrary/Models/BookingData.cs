using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models;

public class BookingData
{
    public int Id { get; set; }
    public int TransportationId { get; set; }
    public int ZoneId { get; set; }
    public int UserId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool WheelChair { get; set; }
    public decimal TotalCost { get; set; }
    public string AddressFrom { get; set; }
    public string AddressTo { get; set; }
}
