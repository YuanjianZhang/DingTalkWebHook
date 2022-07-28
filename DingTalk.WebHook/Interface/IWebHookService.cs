using DingTalk.WebHook.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DingTalk.WebHook.Interface
{
    /// <summary>
    /// 钉钉机器人WebHook 服务能推送的消息类型
    /// </summary>
    /// <remarks>消息类型列表：<see href="https://open.dingtalk.com/document/robots/message-types-and-data-format"/></remarks>
    public interface IWebHookService
    {
        #region 群聊
        string SendTextMsg(SendGroupMsgModelIn msgModel);
        string SendMarkdownMsg(SendGroupMsgModelIn msgModel);
        string SendActionCardMsg(SendGroupMsgModelIn msgModel);
        string SendFeedCardMsg(SendGroupMsgModelIn msgModel);
        string SendLinkMsg(SendGroupMsgModelIn msgModel);

        #endregion
        #region 单聊
        string SendTextMsg(SendOneToOneMsgModelIn msgModel);
        string SendMarkdownMsg(SendOneToOneMsgModelIn msgModel);
        string SendActionCardMsg(SendOneToOneMsgModelIn msgModel);
        string SendFeedCardMsg(SendOneToOneMsgModelIn msgModel);
        string SendLinkMsg(SendOneToOneMsgModelIn msgModel);
        #endregion
    }
}
