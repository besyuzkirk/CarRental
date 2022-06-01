using CarRental.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRental
{
    public partial class ListRentedCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RentedCarDal renteredCarDal = new RentedCarDal();

            var cars = renteredCarDal.ListRentedCar().ToList();
                
            if (cars.Count < 1)
            {
                Console.WriteLine("Data Error");
            }
            else
            {
                ListViewRentedCar.DataSource = cars;
                ListViewRentedCar.DataBind();
    
            }
            Console.WriteLine(cars);
        }
    }
}