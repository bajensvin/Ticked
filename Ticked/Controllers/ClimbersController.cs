using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Ticked.Models;

namespace Ticked.Controllers {
    public class ClimbersController : Controller {
        public ActionResult CreateClimber(ClimbersModel climber) {
            using (EF.ClimbersEntities climbersEf = new EF.ClimbersEntities()) {
                climbersEf.Climbers.Add(new EF.Climbers {
                    FirstName = climber.FirstName,
                    LastName = climber.LastName,
                    HomeGym = climber.HomeGym,
                    ID = climber.ClimberId
                });
                    climbersEf.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        
        public ActionResult EditClimber(int id) {
                return RedirectToAction("Index");
        }
        
        public ActionResult Index() {
            using (EF.ClimbersEntities climbersEf = new EF.ClimbersEntities()) {
                var climber = climbersEf.Climbers.Select(x => new ClimbersModel {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    HomeGym = x.HomeGym,
                    ClimberId = x.ID
                }).ToList();
                return View(new ClimbersViewModel { ListOfClimbers = climber });
            }
        }
    }
}





//Old fashioned way
//public ActionResult SaveClimber(ClimbersModel climber) {
//    string connectionString = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
//    using (SqlConnection con = new SqlConnection(connectionString)) {
//        string query = "INSERT INTO Climbers(FirstName, LastName, HomeGym) VALUES(@FirstName, @LastName, @HomeGym)";
//        using (SqlCommand cmd = new SqlCommand(query, con)) {
//            con.Open();
//            cmd.Parameters.AddWithValue("@FirstName", climber.FirstName);
//            cmd.Parameters.AddWithValue("@LastName", climber.LastName);
//            cmd.Parameters.AddWithValue("@HomeGym", climber.HomeGym);
//            cmd.ExecuteNonQuery();
//        }
//    }
//    return RedirectToAction("Index");
//}
//Old fashioned way
//public ActionResult Index() {
//    string connectionString = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
//    string query = "SELECT * FROM Climbers";
//    List<ClimbersModel> climbersList = new List<ClimbersModel>();
//    using (SqlConnection con = new SqlConnection(connectionString)) {
//        using (SqlCommand cmd = new SqlCommand(query, con)) {
//            con.Open();
//            using (SqlDataReader sqld = cmd.ExecuteReader()) {
//                while (sqld.Read()) {
//                    ClimbersModel climber = new ClimbersModel();
//                    climber.FirstName = sqld["FirstName"].ToString();
//                    climber.LastName = sqld["LastName"].ToString();
//                    //climber.Id = (int)sqld["ID"];
//                    climber.HomeGym = sqld["HomeGym"].ToString();
//                    climbersList.Add(climber);
//                }
//            }
//        }
//    }
//    return View(new ClimbersViewModel { listOfClimbers = climbersList });
//}