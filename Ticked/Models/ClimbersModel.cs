using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticked.Models {
    public class ClimbersModel {
        public int ClimberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeGym { get; set; }
        //public ClimbersModel(string firstName, string lastName, string homeGym) {
        //    this.fName = firstName;
        //    this.lName = lastName;
        //    this.hGym = homeGym;
        //}
    }
}