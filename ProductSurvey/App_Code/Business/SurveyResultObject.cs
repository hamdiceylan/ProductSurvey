using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductSurvey.App_Code.Business
{
    public class SurveyResultObject
    {
        public string Name { get; set; }
        public Nullable<int> Product1 { get; set; }
        public Nullable<int> Product2 { get; set; }
        public Nullable<int> Product3 { get; set; }
        public Nullable<int> Product4 { get; set; }
    }
}