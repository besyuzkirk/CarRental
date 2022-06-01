using CarRental.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRental
{
    public partial class ReturnCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            RentedCarDal rentedCarDal = new RentedCarDal();
            CarDal carDal = new CarDal();
            var id = Convert.ToInt32(CarReturn.Text.ToString());

            int CarId = rentedCarDal.GetRentedCar(id).CarId;


            rentedCarDal.UpdateRendetStatus(id,false);
            carDal.UpdateCarStatus(CarId, true);
        }
    }
}