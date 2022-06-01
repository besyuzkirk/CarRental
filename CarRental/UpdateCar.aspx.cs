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
    public partial class UpdateCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["Id"] != null)
            {
                CarID.Visible = false;
                carIdText.InnerHtml = "Car ID: " + Request.Params["Id"];
            }
        }

        protected void UpdateACar(object sender, EventArgs e)
        {

            int id = 0;

            if(Request.Params["Id"] != null)
            {
                id = Convert.ToInt32(Request.Params["Id"].ToString());
            }  
            else
            {
                 id = Convert.ToInt32(CarID.Text.ToString());
            }
            
            

            CarDal carDal = new CarDal();

            Car car = new Car
            {
                CarName = CarName.Text.ToString(),
                ImgUrl = CarImage.Text.ToString(),
                ShiftType = Transamission.Text.ToString(),
                Luggage = Luggage.Text.ToString(),
                AirConditioning = AirConditioning.Text.ToString(),
                Seats = CarCapacity.Text.ToString(),
                Price = DailyPrice.Text.ToString(),
            };

            carDal.UpdateCar(id , car);
            Response.Redirect("Default.aspx");


        }
    }
}