using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ticked.Models {
    public class ClimbersViewModel {
        public ClimbersModel Climber { get; set; }
        public List<ClimbersModel> ListOfClimbers { get; set; }
    }
}