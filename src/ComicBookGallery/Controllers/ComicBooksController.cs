using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers {
    public class ComicBooksController : Controller {
        // ABOVE: controller classes need to be public 


        // Action Method---also needs to be public to use
        // .../ComicBooks/Detail
        public ActionResult Detail() {

            // if .../ComicBooks/Detail is called on DAYOFTHEWEEK, it will redirect to content
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday) {
                return Redirect("/");
            }

            return Content("Hello from the comic books controller!");
        }

    }
}