using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ticked {
    public static class Utilities {
        public static string IsActive(this HtmlHelper html, string control, string action) {
            var routeData = html.ViewContext.RouteData;
            var routeAction = (string)routeData.Values["action"];
            var routeControl = (string)routeData.Values["controller"];

            bool returnActive;

            if(control == routeControl && action == routeAction) {
                returnActive = true;
            } else {
                returnActive = false;
            }

            if (returnActive == true) {
                return "active"; 
            } else {
                return "";
            }
        }
    }
}