using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Linq;
using System.Web;


namespace CarRental
{
    public partial class Register : System.Web.UI.Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            // Default UserStore constructor uses the default connection string named: DefaultConnection
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);
            var user = new IdentityUser() { UserName = UserName.Text, Email = Email.Text, PhoneNumber = PhoneNUmber.Text };
            var role = new IdentityUserRole() { UserId = user.Id, RoleId = "2" };
            IdentityResult result = manager.Create(user, Password.Text);




            if (result.Succeeded)
            {
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authenticationManager.SignIn(new AuthenticationProperties() { }, userIdentity);
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                StatusMessage.Text = result.Errors.FirstOrDefault();
            }



        }

        protected void Login_Click(object sender, EventArgs e)
        {
            // Default UserStore constructor uses the default connection string named: DefaultConnection
            Response.Redirect("~/Login.aspx");
        }
    }
}