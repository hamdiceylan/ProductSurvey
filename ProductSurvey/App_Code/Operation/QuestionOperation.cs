using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductSurvey.App_Code.Business;
using ProductSurvey.Models;

namespace ProductSurvey.App_Code.Operation
{
    public class QuestionOperation
    {
        public List<QuestionObject> GetAllQuestion()
        {
            List<QuestionObject> result = new List<QuestionObject>();

            using (SurveyEntities entity = new SurveyEntities())
            {
                result = (from p in entity.Questions
                          select new QuestionObject
                          {
                              Id = p.Id,
                              Name = p.Name,
                          }).ToList();
            }
            return result;
        }
    }
}