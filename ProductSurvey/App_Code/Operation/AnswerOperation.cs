using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductSurvey.App_Code.Business;
using ProductSurvey.Models;

namespace ProductSurvey.App_Code.Operation
{
    public class AnswerOperation
    {
        public List<AnswerObject> GetAllAnswer()
        {
            List<AnswerObject> result = new List<AnswerObject>();

            using (SurveyEntities entity = new SurveyEntities())
            {
                result = (from p in entity.Answers
                          select new AnswerObject
                          {
                              QuestionId = p.QuestionId,
                              ProductId = p.ProductId,
                          }).ToList();
            }
            return result;
        }
    }
}