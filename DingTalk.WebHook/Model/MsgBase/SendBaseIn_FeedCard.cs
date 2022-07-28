using System;
using System.Collections.Generic;
using System.Text;

namespace DingTalk.WebHook.Model.MsgBase
{
    public class SendBaseIn_FeedCard
    {
        public List<SendBaseIn_LinkNode> links { get; set; }
    }
}
