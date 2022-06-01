using CarRental.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRental
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            CarDal carDal = new CarDal();
            
            var cars = carDal.ListCarsWithStatus().ToList();

            if (cars.Count < 1)
            {
                Console.WriteLine("Data Error");
            }
            else
            {
                ListView1.DataSource = cars;
                ListView1.DataBind();
            }
            Console.WriteLine(cars);

        }


    }
}