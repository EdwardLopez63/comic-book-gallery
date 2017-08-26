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

            return View();
        }
    }
}