using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMVCLib
{
    public class RawContextResult:ActionResult
    {
        public string RawData { get; private set; }
        public RawContextResult(string rawData)
        {
            this.RawData = rawData;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            context.RequestContext.HttpContext.Response.Write(this.RawData);
        }
    }
}
