using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECalculator.Models;

namespace ECalculator.Controllers
{
    public class CalcController : Controhllern
    {
        //
        // GET: /Calc/

        public ActionResult Calculate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(CalcModel calcModel) 
        {
            calcModel.Calculate();
            return View(calcModel);
        }
    }
}
