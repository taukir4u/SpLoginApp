using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SpLoginApp.DAL;
using SpLoginApp.Enitities;

namespace SpLoginApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
          

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserDAL userDal = new UserDAL();
            LoginLogDAL loginLogDal = new LoginLogDAL();
           
            
            Enitities.User user = userDal.EmailCheck(TextBoxUsername.Text.Replace("'", "`"));


            if (user != null)
            {
                Enitities.User userLogin = userDal.Login(TextBoxUsername.Text.Replace("'", "`"),
                    TextBoxPassword.Text.Replace("'", "`"));
                if (userLogin != null)
                {
                    msg.Text = userLogin.Status;
                    if (userLogin.Status == "9")
                    {
                        msg.Text = "Your Account is Banned!";
                    }
                    else
                    {
                        loginLogDal.ClearLog(userLogin.Id);
                        Response.Redirect("Default.aspx");
                    }
                }
                else
                {
                    msg.Text = "Password is incorrect";
                    int loginTry = loginLogDal.LoginTry(user.Id);
                    if (loginTry > 4)
                    {
                        userDal.BlockUser(user.Id);
                        msg.Text = "You have tried more than 4 times, Your Account is Blocked";
                    }
                    else
                    {
                        LoginLog log = new LoginLog();
                        log.UserId = user.Id;
                        loginLogDal.Save(log);
                    }
                    
                }
            }
            else
            {
                msg.Text = "You have no account";
            }

        }
    }
}