using System;
using System.Collections.Generic;
using System.Text;

namespace DingTalk.WebHook.Model
{
    /// <summary>
    /// 单聊消息模板
    /// </summary>
    public class SendOneToOneMsgModelIn
    {
        private string _msgtype = "empty";
        public string msgtype { get { return _msgtype; } }

    }
}
