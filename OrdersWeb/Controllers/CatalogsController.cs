using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrdersWeb.Controllers
{
    public class CatalogsController : Controller
    {
        // GET: Category
        [Authorize]
        public ActionResult Categories()
        {
            return View();
        }
        [Authorize]
        public ActionResult Products()
        {
            return View();
        }

    }
}