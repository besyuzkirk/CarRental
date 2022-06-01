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
    public partial class AddCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddNewCar(object sender, EventArgs e)
        {
            var carName = CarName.Text.ToString();
            var shiftType = Transamission.Text.ToString();
            var imgUrl = CarImage.Text.ToString();
            var seats = CarCapacity.Text.ToString();
            var luggage = Luggage.Text.ToString();
            var price = DailyPrice.Text.ToString();
            var airCondition = TextBox1.Text.ToString();

            Car car = new Car
            {
                AirConditioning = airCondition,
                CarName = carName,
                ImgUrl = imgUrl,
                Luggage = luggage,
                Price = price,
                Seats = seats,
                ShiftType = shiftType,
                Status = true
            };

            CarDal carDal = new CarDal();
            carDal.AddNewCar(car);
            Response.Redirect("Default.aspx");
        }

    }
}