using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticked.Models {
    public class ClimbersModel {
        public string fName { get; set; }
        public string lName { get; set; }
        public string hGym { get; set; }
        public ClimbersModel(string firstName, string lastName, string homeGym) {
            this.fName = firstName;
            this.lName = lastName;
            this.hGym = homeGym;
        }
    }
}