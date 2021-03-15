using ExCodeFxGIT.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExCodeFxGIT.Controllers
{
    public class EmpController : Controller
    {
        EmpContext db = new EmpContext();
        // GET: Emp
        public ActionResult Index()
        {

            return View(db.Emps.ToList());
        }
    }
}