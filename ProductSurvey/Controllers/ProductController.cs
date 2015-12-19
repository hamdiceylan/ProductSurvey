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
    public class ProductController : ApiController
    {
        public List<ProductObject> GetAllProduct()
        {
            ProductOperation po = new ProductOperation();
            return po.GetAllProduct();
        }
    }
}
