using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductSurvey.App_Code.Operation;
using ProductSurvey.App_Code.Business;

namespace ProductSurvey.Controllers
{
    public class QuestionController : ApiController
    {
        public List<QuestionObject> GetAllQuestion()
        {
            QuestionOperation qo = new QuestionOperation();
            return qo.GetAllQuestion();
        }
    }
}
