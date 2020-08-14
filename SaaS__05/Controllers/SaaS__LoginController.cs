using SaaS__05.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaaS__05.Controllers;    
    

namespace SaaS__05.Controllers
{
    public class SaaS__LoginController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: SaaS__Login
        public ActionResult Login()
        {
            return View();
        }
        void connenctionString()
        {
            con.ConnectionString = "data source=DESKTOP-KLCN2EP; database=SaaS__01;integrated security =SSPI;";

        }
        [HttpPost]
        public ActionResult Verify(SaaS__Utilisateur u)
        {
            connenctionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from SaaS__Utilisateur where Email='" + u.Email + "' and Password='" + u.Password + "'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                con.Close();
                return RedirectToAction("Indexx", "Home");
            }
            else
            {
                con.Close();
                return View("Error");
            }
        }
    }
}