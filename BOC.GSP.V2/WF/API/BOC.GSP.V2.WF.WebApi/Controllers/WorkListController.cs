using BOC.GSP.V2.WF.Common.Variable;
using BOC.GSP.V2.WF.DAL.Repository;
using BOC.GSP.V2.WF.Engine;
using BOC.GSP.V2.WF.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BOC.GSP.V2.WF.WebApi.Controllers
{
    [RoutePrefix("api/WorkList")]
    public class WorkListController : ApiController
    {
        [Route("Process")]
        [HttpPost]
        public IHttpActionResult Process(Reqeust req)
        {
            string msg = string.Empty;
            ActivityPara para = new ActivityPara();
            //para.ProcessID = req.ProcessId.Value;
            para.RunTimeInstanceId = req.InstanceId.Value;
            para.Remark = req.Remark;
            para.WorkListid = req.WorkListId.Value;
            para.Approvers = req.Approvers;
            para.Action = req.Action;
            para.ADUser = "laoma";
            Instance.Continue(para, out msg);
            //return Res(Status.Sucess, "Sucess", null);
            return Ok();
        }
        [Route("MyWork")]
        [HttpGet]
        public IHttpActionResult GetMyWorkListbyItemId(string userid, Guid workListId)
        {
            string res = string.Empty;
            var respnse = WorkListRepository.GetMyWorkListbyItemId(userid, workListId, out res);
            return Ok(respnse);
        }

        [Route("MyWorkList")]
        [HttpGet]
        public IHttpActionResult GetMyWorkList(string userid)
        {
            string res = string.Empty;
            var respnse = WorkListRepository.GetMyWorkList(userid, out res);
            return Ok(respnse);
        }
        [Route("WorkList")]
        public HttpResponseMessage GetWorkList()
        {
            var response = WorkListRepository.GetWorkList();
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        #region Private Methords
        private System.Web.Http.Results.OkNegotiatedContentResult<APIResponse> Res(Status status, string message, object body)
        {
            APIResponse res = new APIResponse
            {
                Status = (int)status,
                Message = message,
                body = body
            };
            return Ok<APIResponse>(res);
        }
        #endregion
    }
}
