using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductSurvey.App_Code.Business;
using ProductSurvey.Models;

namespace ProductSurvey.App_Code.Operation
{
    public class ProductOperation
    {
        public List<ProductObject> GetAllProduct()
        {
            List<ProductObject> result = new List<ProductObject>();

            using (SurveyEntities entity = new SurveyEntities())
            {
                result = (from p in entity.Products
                          select new ProductObject
                          {
                              Id = p.Id,
                              Name = p.Name,
                          }).ToList();
            }
            return result;
        }
    }
}