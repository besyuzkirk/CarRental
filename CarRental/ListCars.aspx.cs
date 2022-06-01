using CarRental.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRental
{
    public partial class ListCars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarDal carDal = new CarDal();

            var cars = carDal.ListCars().ToList();

            if (cars.Count < 1)
            {
                Console.WriteLine("Data Error");
            }
            else
            {
                ListView12.DataSource = cars;
                ListView12.DataBind();
            }
            Console.WriteLine(cars);
        }
    }
}