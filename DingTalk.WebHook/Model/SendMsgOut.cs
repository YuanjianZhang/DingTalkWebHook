using System;
using System.Collections.Generic;
using System.Text;

namespace DingTalk.WebHook.Model
{
    /// <summary>
    /// 推送消息，DingTalk 响应参数
    /// </summary>
    public class SendMsgOut
    {
        public string errcode { get; set; }
        public string errmsg { get; set; }
    }
}
