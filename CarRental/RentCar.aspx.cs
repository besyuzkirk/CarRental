using CarRental.DataAccess;
using CarRental.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRental
{
    public partial class RentCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.Params["Id"].ToString());
            CarDal carDal = new CarDal();
            var car = carDal.GetCar(id);

            Label1.Text = car.CarName;

        }

      

        protected void Button1_Click(object sender, EventArgs e)
        {
            var endDate = DateTime.Parse(EndDate.Text.ToString());
            var startDate = DateTime.Parse(StartDate.Text.ToString());

            int id = Convert.ToInt32(Request.Params["Id"].ToString());

            CarDal carDal = new CarDal();
            var car = carDal.GetCar(id);
            int price = Convert.ToInt32(car.Price);

            var totalDays = (endDate - startDate).TotalDays.ToString();
            var calculation = Convert.ToInt32(totalDays) * price;

            deneme.Text = "Price: $" + calculation.ToString();
        }

        protected void Checkout(object sender, EventArgs e)
        {
            var endDate = DateTime.Parse(EndDate.Text.ToString());
            var startDate = DateTime.Parse(StartDate.Text.ToString());

            int id = Convert.ToInt32(Request.Params["Id"].ToString());
            string userId = Session["UserId"].ToString();

            

            CarDal carDal = new CarDal();
            var car = carDal.GetCar(id);

            //eklenecek:
            //car status == false ise kiralayamaz.
            //

            int price = Convert.ToInt32(car.Price);

            var totalDays = (endDate - startDate).TotalDays.ToString();
            var calculation = Convert.ToInt32(totalDays) * price;
                
            RentedCar rentedCar = new RentedCar
            {
                CarId = id,
                EndDate = endDate,
                StartDate = startDate,
                TotalDay = Convert.ToInt32(totalDays),
                TotalRevenue = calculation,
                UserId = userId,
                Status = true
            };

            RentedCarDal rentedCarDal = new RentedCarDal();
           
            rentedCarDal.AddRentedCar(rentedCar);
            carDal.UpdateCarStatus(id, false);

            Response.Redirect("~/SuccessPage.aspx");

        }

    }
}