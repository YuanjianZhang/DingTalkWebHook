using DingTalk.WebHook.Model.MsgBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace DingTalk.WebHook.Model
{
    /// <summary>
    /// 群聊消息模板
    /// </summary>
    public class SendGroupMsgModelIn
    {
        public SendGroupMsgModelIn()
        {

        }
        public SendGroupMsgModelIn(MsgType type)
        {
            this.msgtype = Enum.GetName(typeof(MsgType), type);
        }
        public string msgtype { get; set; }
        public SendBaseIn_AtNode at { get; set; }
        public SendBaseIn_Text text { get; set; }
        public SendBaseIn_Markdown markdown { get; set; }
        public SendBaseIn_ActionCard actionCard { get; set; }
        public SendBaseIn_FeedCard feedCard { get; set; }
        public SendBaseIn_Link link { get; set; }

    }
}
