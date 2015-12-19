using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductSurvey.App_Code.Business;
using ProductSurvey.Models;

namespace ProductSurvey.App_Code.Operation
{
    public class SurveyResultOperation
    {
        public List<SurveyResultObject> GetSurveyResults()
        {
            List<SurveyResultObject> result = new List<SurveyResultObject>();

            using (SurveyEntities entity = new SurveyEntities())
            {
                result = (from p in entity.GetResults()
                          select new SurveyResultObject
                          {
                              Name = p.Name,
                              Product1 = p.pro1,
                              Product2 = p.pro2,
                              Product3 = p.pro3,
                              Product4 = p.pro4,
                          }).ToList();
            }
            return result;
        }
    }
}