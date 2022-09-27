using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public class OkResultModel
    {
        public string ResultCode { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
    }

    public static class OkResultCodesModel
    {
        public const string ResultCodeOk = "OK";
        public const string ResultCodeError = "ERROR";
    }
}
