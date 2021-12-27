using System.Collections.Generic;

namespace WpsOnline.Model
{
    /// <summary>
    /// 用来过滤下WPS回调的参数（包含url参数/headers）
    /// 继承了ErrorModel，如果请求参数不正常可直接返回error信息
    /// </summary>
    public class RequestParam : WPSBaseModel
    {
        /// <summary>
        /// 请求参数是否正常
        /// </summary>
        public bool Status { get; set; } = true;

        /// <summary>
        /// 文件ID
        /// </summary>
        public string FileId { get; set; }

        /// <summary>
        /// url参数
        /// </summary>
        public Dictionary<string, string> Params { get; set; }
    }
}
