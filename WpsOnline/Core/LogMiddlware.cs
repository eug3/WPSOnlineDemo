//using log4net;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WpsOnline.Core
{
    /// <summary>
    /// 日志中间件，记录访问信息
    /// </summary>
    public class LogMiddlware
    {
       // private ILog _logger = LogManager.GetLogger("wps", "");
        private RequestDelegate _next;
        public LogMiddlware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
           // _logger.Debug($"被访问，访问路径为：{(context.Request.Path.HasValue ? context.Request.Path.Value : "无")}");
            await _next(context);
        }
    }
}
