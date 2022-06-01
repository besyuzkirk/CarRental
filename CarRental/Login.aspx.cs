using CarRental.DataAccess;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarRental
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.IsAuthenticated)
                {
                    //StatusText.Text = string.Format("Hello {0}!!", User.Identity.GetUserName());
                    //LoginStatus.Visible = true;
                    //LogoutButton.Visible = true;
                    Response.Redirect("Default.aspx");
                    

                }
                else
                {
                    LoginForm.Visible = true;
                }
            }
        }

        protected void SignIn(object sender, EventArgs e)
        {
            UserDal userDal = new UserDal();

            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            var user = userManager.Find(UserName.Text, Password.Text);

            if (user != null)
            {
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
                var userId = user.Id.ToString();

                if(userDal.getUserRole(userId) != null)
                {
                    var role = userDal.getUserRole(userId).Role.ToString();
                    Session["Role"] = role.ToString();
                }
                Session["UserId"] = userId;
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                StatusText.Text = "Invalid username or password.";
                LoginStatus.Visible = true;
            }
        }

        protected void SignOut(object sender, EventArgs e)
        {
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            Session.Clear(); 
            Response.Redirect("~/Login.aspx");

        }

        protected void SignUp(object sender, EventArgs e)
        {
            
            Response.Redirect("~/Register.aspx");

        }
    }
}