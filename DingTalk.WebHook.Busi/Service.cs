using DingTalk.Common;
using DingTalk.WebHook.Common;
using DingTalk.WebHook.Interface;
using DingTalk.WebHook.Model;


namespace DingTalk.WebHook.Busi
{
    public class Service : IWebHookService
    {

        public string SendMsg(object msgModel)
        {
            try
            {
                var respone = HttpHelper.Post(WebHookHelper.CombineRequestUrl(), JsonHelper.SerializeObject(msgModel));
                return respone.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string SendActionCardMsg(SendGroupMsgModelIn msgModel)
        {
            throw new NotImplementedException();

        }

        public string SendActionCardMsg(SendOneToOneMsgModelIn msgModel)
        {
            throw new NotImplementedException();

        }

        public string SendFeedCardMsg(SendGroupMsgModelIn msgModel)
        {
            throw new NotImplementedException();

        }

        public string SendFeedCardMsg(SendOneToOneMsgModelIn msgModel)
        {
            throw new NotImplementedException();

        }

        public string SendLinkMsg(SendGroupMsgModelIn msgModel)
        {
            throw new NotImplementedException();

        }

        public string SendLinkMsg(SendOneToOneMsgModelIn msgModel)
        {
            throw new NotImplementedException();

        }

        public string SendMarkdownMsg(SendGroupMsgModelIn msgModel)
        {
            throw new NotImplementedException();

        }

        public string SendMarkdownMsg(SendOneToOneMsgModelIn msgModel)
        {
            throw new NotImplementedException();
        }


        public string SendTextMsg(SendGroupMsgModelIn msgModel)
        {
            try
            {
                return SendMsg(msgModel);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string SendTextMsg(SendOneToOneMsgModelIn msgModel)
        {
            try
            {
                return SendMsg(msgModel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}