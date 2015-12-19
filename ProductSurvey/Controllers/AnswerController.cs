using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductSurvey.App_Code.Business;
using Newtonsoft.Json;
using ProductSurvey.Models;

namespace ProductSurvey.Controllers
{
    public class AnswerController : ApiController
    {
        [HttpPost]
        public string PostAnswer(List<AnswerObject> AnswerList)
        {
            string result = String.Empty;
            using (SurveyEntities entity = new SurveyEntities())
            {
                try
                {
                    foreach (var answer in AnswerList)
                    {
                        Answer currentAnswer = new Answer();
                        currentAnswer.ProductId = answer.ProductId;
                        currentAnswer.QuestionId = answer.QuestionId;
                        entity.Answers.Add(currentAnswer);
                        entity.SaveChanges();
                        result = "Answers are added successfully";    
                    }
                }
                catch (Exception)
                {
                    result = "An error occurred during this operation.";
                }
            }
            return result;
        }
    }
}
