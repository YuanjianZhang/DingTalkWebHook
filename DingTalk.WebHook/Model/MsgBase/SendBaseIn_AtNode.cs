using System;
using System.Collections.Generic;
using System.Text;

namespace DingTalk.WebHook.Model.MsgBase
{
    public class SendBaseIn_AtNode
    {
        private string[] _atMobiles = null;
        private string[] _atUserIds = null;
        private bool _isatall = false;
        public string[] atMobiles { get { return _atMobiles; } set { _atMobiles = value; } }
        public string[] atUserIds { get { return _atUserIds; } set { _atUserIds = value; } }
        public bool isAtAll { get { return _isatall; } set { _isatall = value; } }
    }
}
