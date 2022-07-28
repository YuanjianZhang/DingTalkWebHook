using System;
using System.Collections.Generic;
using System.Text;

namespace DingTalk.WebHook.Model.MsgBase
{
    public class SendBaseIn_Link
    {
        /// <summary>
        /// 是 消息标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 是 消息内容 如果太长只会部分展示
        /// </summary>
        public string text { get; set; }
        /// <summary>
        ///  是 点击消息跳转的URL
        /// </summary>
        public string messageUrl { get; set; }
        /// <summary>
        /// 否 图片URL
        /// </summary>
        public string picUrl { get; set; }
    }
}
