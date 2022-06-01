using CarRental.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRental
{
    public partial class SiteMaster : MasterPage
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] != null)
            {
                var isRole = Session["Role"].ToString() == "1" ? true : false;

                if (isRole)
                {
                    addcar.Visible = true;
                    allCar.Visible = true;
                    orderCars.Visible = true;
                    A1.Visible = true;
                    A2.Visible = true;
                    home.Visible = false;
                    about.Visible = false;
                    contact.Visible = false;
                    applicationName.InnerHtml = "Admin";
                    
                }
            }

            if(Session["Role"] == null)
            {
                addcar.Visible = false;
                allCar.Visible = false;
                orderCars.Visible = false;
                A1.Visible = false;
                A2.Visible = false;
                applicationName.InnerHtml = "MIS Rental Car";
            }

          
        }

    }
}