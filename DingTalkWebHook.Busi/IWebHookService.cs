using System;
using System.Collections.Generic;
using System.Text;

namespace DingTalkWebHook.Busi
{
    public interface IWebHookService
    {
        string SendTextMessage(string message);
    }
}
