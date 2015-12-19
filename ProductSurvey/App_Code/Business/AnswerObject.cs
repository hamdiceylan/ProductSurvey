using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductSurvey.App_Code.Business
{
    public class AnswerObject
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public Nullable<int> ProductId { get; set; }
    }
}