using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Ticked.Models;

namespace Ticked.Controllers
{
    public class ClimbersController : Controller {
        // GET: Climbers
        [HttpPost]
        public ActionResult SaveClimber(ClimbersModel climber) {
            string constr = WebConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr)) {
                string query = "INSERT INTO Climbers(FirstName, LastName, HomeGym) VALUES(@FirstName, @LastName, @HomeGym)";
                using (SqlCommand cmd = new SqlCommand(query)) {
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@FirstName", climber.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", climber.LastName);
                    cmd.Parameters.AddWithValue("@HomeGym", climber.HomeGym);
                    //climber.ClimberId = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
            }
            return View();
        }
        public ActionResult Index() {
            return View();
        }
    }
}