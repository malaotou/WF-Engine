using BOC.GSP.V2.WF.Common.Utility;
using BOC.GSP.V2.WF.Common.Variable;
using BOC.GSP.V2.WF.DAL.Repository;
using BOC.GSP.V2.WF.Engine;
using BOC.GSP.V2.WF.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BOC.GSP.V2.WF.WebApi.Controllers
{
    [RoutePrefix("api/WF")]
    public class WFController : ApiController
    {
        [Route("Process")]
        [HttpPost]
        public HttpResponseMessage Process(Reqeust req)
        {
            bool rtn = true;
            string msg = string.Empty;
            HttpError err = null;
            ActivityPara para = new ActivityPara();
            para.Body = Utility.SerializeToString(req.Body);
            para.Remark = req.Remark;
            Guid InstanceId = Guid.NewGuid();
            if (req.InstanceId != null)
            {
                InstanceId = req.InstanceId.Value;
            }
            try
            {
                if (string.IsNullOrEmpty(req.Command))
                {
                    err = new HttpError("指令参数：Command 不能为空!");
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, err);
                }

                para.ADUser = "laoma";
                Dictionary<string, object> paralist = new Dictionary<string, object>();
                paralist.Add("para", para);
                if (req.Command.ToLower() == "start")
                {
                    if (req.ProcessId == null || req.ProcessId == Guid.Empty)
                    {
                        err = new HttpError("发起流程参数：ProcessId 不能为空!");
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, err);
                    }
                    para.ActType = 1;
                    para.ProcessID = req.ProcessId.Value;
                    if (req.Approvers != null)
                    {
                        para.Approvers = req.Approvers;
                    }
                    rtn = Instance.Run(paralist, out msg);
                }
                else if (req.Command.ToLower() == "pause")
                {
                    if (req.InstanceId == null || req.InstanceId == Guid.Empty)
                    {
                        err = new HttpError("发起流程参数：ProcessId 不能为空!");
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, err);
                    }
                    para.ProcessInstanceId = req.InstanceId.Value;
                    rtn = Instance.Pause(para, out msg);
                }
                else if (req.Command.ToLower() == "cancel")
                {
                    if (req.InstanceId == null || req.InstanceId == Guid.Empty)
                    {
                        err = new HttpError("发起流程参数：ProcessId 不能为空!");
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, err);
                    }
                    para.ProcessInstanceId = req.InstanceId.Value;
                    rtn = Instance.Cancel(para, out msg);
                }
                else if (req.Command.ToLower() == "resume")
                {
                    if (req.InstanceId == null || req.InstanceId == Guid.Empty)
                    {
                        err = new HttpError("发起流程参数：ProcessId 不能为空!");
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, err);
                    }
                    para.ProcessInstanceId = req.InstanceId.Value;
                    rtn = Instance.Resume(para, out msg);
                }
                else
                {
                    err = new HttpError("发起流程参数：Command 指令错误!");
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, err);
                }
                if (rtn)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, InstanceId);
                    //return Ok(InstanceId);
                }
                else
                {
                    err = new HttpError(msg);
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, err);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new HttpError(ex.Message));
            }
        }

        [Route("ListProcessDefine")]
        [HttpGet]
        public HttpResponseMessage ListProcessDefine()
        {
            var processes = ProcessRepository.GetProcesses();
            return Request.CreateResponse(HttpStatusCode.OK, processes);
        }
        [Route("ListAllInstance")]
        [HttpGet]
        public HttpResponseMessage ListProcessInstance()
        {
            return Request.CreateResponse(HttpStatusCode.OK, ProcessRepository.GetAllProcessInstance());
        }
    }
}
