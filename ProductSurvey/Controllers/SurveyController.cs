using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductSurvey.Controllers;

namespace ProductSurvey.Controllers
{
    public class SurveyController : Controller
    {
        //
        // GET: /Survey/
        public ActionResult Index()
        {
            QuestionController qc = new QuestionController();
            ViewBag.question = qc.GetAllQuestion();
            ProductController pc = new ProductController();
            ViewBag.product = pc.GetAllProduct();
            return View();
        }
        public ActionResult Results()
        {
            SurveyResultsController src = new SurveyResultsController();
            ViewBag.results = src.GetResults();
            return View();
        }
	}
}