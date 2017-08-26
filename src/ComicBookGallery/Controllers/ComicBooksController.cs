using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers {
    public class ComicBooksController : Controller {
        // ABOVE: controller classes need to be public 


        // Action Method---also needs to be public to use
        public string Detail() {
            return "Hello from the comic books controller";
        }

    }
}