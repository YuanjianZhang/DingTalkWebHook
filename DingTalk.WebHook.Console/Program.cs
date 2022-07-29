using DingTalk.WebHook.Busi;
using DingTalk.WebHook.Model;
using System.Reflection;
using System.Text;

bool keeprun = true;
do
{
    try
    {
        Console.WriteLine("选择推送类型");
        Print.PrintEnum<MsgType>();
        bool flag = false;
        MsgType type;
        do
        {
            flag = Enum.TryParse<MsgType>(Print.ReadSingleLine(), out type);
            if(!flag) Console.WriteLine("\n错误类型，重新输入:");
        } while (!flag);

        var msg = string.Empty;
        ConsoleKeyInfo ki;
        do
        {
            Console.Write("输入消息(Enter 结束输入)：");
            msg = Print.ReadSingleLine();
            var respone = string.Empty;
            Service webhookservice = new Service();
            switch (type)
            {
                case MsgType.text:
                case MsgType.markdown:
                case MsgType.actionCard:
                case MsgType.feedCard:
                case MsgType.link:
                default:
                    respone = webhookservice.SendTextMsg(new SendGroupMsgModelIn(type)
                    {
                        text = new()
                        {
                            content = msg
                        },
                        at = new()
                        {
                            isAtAll = true,
                            atMobiles = null,
                            atUserIds = null
                        }
                    });
                    break;
            }
            Console.WriteLine("推送完成：" + respone);
            Console.WriteLine(@"键入""C""继续");
            ki = Console.ReadKey(true);
        } while (ki.Key==ConsoleKey.C);
        Console.WriteLine("推送结束！Enter 退出程序");
        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
        {
            keeprun = false;
            //Environment.Exit(0);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("异常：" + ex.Message);
    }
} while (keeprun);

internal class Print
{
    public static void PrintEnum<T>() where T : Enum
    {
        Console.WriteLine($@"{typeof(T).Name} 枚举值如下：");
        var fieldInfos = typeof(T).GetFields(BindingFlags.Public|BindingFlags.Static|BindingFlags.GetField);
        foreach (var item in fieldInfos)
        {
            Console.WriteLine($@"* {item.Name} : {item.GetRawConstantValue()}");
        }
    }

    public static string ReadSingleLine()
    {
        var input = string.Empty;
        do
        {
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                Console.WriteLine("错误值，重新输入：");
        } while (string.IsNullOrWhiteSpace(input));
        return input;
    }

}



