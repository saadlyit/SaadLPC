using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAADLPC
{
    public partial class Login : System.Web.UI.Page
    {
        ReportsEntities db = new ReportsEntities();
        usertable user = new usertable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void createlog(string username, string category, string description)
        {

            SysLogEvent log = new SysLogEvent();
            log.UserName = username;
            log.Description = description;
            log.Status = category;

            db.SysLogEvents.Add(log);
            db.SaveChanges();
            //sysdiagram logs = new sysdiagram();
            //logs.principal_id = userID;
            //logs.name = category;
            //logs.definition = description;
            //db.sysdiagrams.Add(logs);
            //int success = db.SaveChanges();
            //if (success==0)
            //{
            //    success.text = "Error creating logs";
            //}
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            bool authenticated = false;
            var usernmae = inputEmail.Text.Trim();
            var password = inputPassword.Text.Trim();
            foreach (var user in db.usertables.Where(t => t.Username == usernmae && t.Password == password))
            {
                authenticated = true;
                // createlog(user.ID, "login", "User" + user.Username.ToString() + "Authenticated Successfully");
            
            }
            if (authenticated)
            {
                //((MasterPage)this.Master).currentUser = this.user;
                //  Response.Redirect("~/Home.aspx");
                createlog(usernmae, "verifed", "got access in system");
                // user = record;    
                // flag = true;
                //Session["user"] = user;

                Response.Redirect("~/Pages/Home.aspx");
            }
            else
            {
                lblerror.Text = "problem logging in";
                createlog(usernmae, "verifed", "not able to access system");
            }
        }
    }
}