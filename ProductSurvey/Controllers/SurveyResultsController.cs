using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductSurvey.App_Code.Business;
using ProductSurvey.App_Code.Operation;
using ProductSurvey.Models;

namespace ProductSurvey.Controllers
{
    public class SurveyResultsController : ApiController
    {
        public List<SurveyResultObject> GetResults()
        {
            SurveyResultOperation sro = new SurveyResultOperation();
            return sro.GetSurveyResults();
        }
    }
}
