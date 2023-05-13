﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VOL.Core.Controllers.Basic;
using VOL.Core.DBManager;
using VOL.Entity.DomainModels;
using VOL.System.IServices;

namespace VOL.System.Controllers
{
    [Route("api/Sys_Log")]
    public partial class Sys_LogController : ApiBaseController<ISys_LogService>
    {
        public Sys_LogController(ISys_LogService service)
        : base("System", "System", "Sys_Log", service)
        {
        }
        [Route("test"), AllowAnonymous, HttpGet]
        public IActionResult Test()
        {
            return Content("11");
        }
    }
}
