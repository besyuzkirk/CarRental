using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental.Model
{
    public class Car
    {
        public string Id { get; set; }
        public string CarName { get; set; }
        public string ShiftType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public string ImgUrl { get; set; }
        public string Seats { get; set; }
        public string Luggage { get; set; }
        public string AirConditioning { get; set; }
        public string Price { get; set; }
        public bool Status { get; set; }
    }
}