using System;
using System.Collections.Generic;
using System.Text;

namespace DingTalk.WebHook.Model.MsgBase
{
    public class SendBaseIn_ActionCard
    {
        

        /// <summary>
        /// 首屏会话透出的展示内容。
        /// </summary>
        public string title { get; set; }
        public string text { get; set; }

        /**整体跳转actionCard**/
        public string singleTitle { get; set; }
        
        public string singleURL { get; set; }

        /**独立跳转actionCard类型**/

        /// <summary>
        /// 按钮排列顺序。
        /// 0：按钮竖直排列
        /// 1：按钮横向排列
        /// </summary>
        public string btnOrientation { get; set; }
        public List<SendBaseIn_BtnNode> btns { get; set; }
    }
}
