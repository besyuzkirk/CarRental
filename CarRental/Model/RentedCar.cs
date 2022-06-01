using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental.Model
{
    public class RentedCar
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public int TotalDay { get; set; }
        public int TotalRevenue { get; set; }
        public string UserId { get; set; }
        public bool Status { get; set; }
    }
}