using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telegram.Bot.Types.Enums;
using System.IO;

namespace robotHamsohbat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Runasync();
        }
        

        static async Task Runasync()
        {
            var bot = new Telegram.Bot.TelegramBotClient("225047213:AAHMueC2hE3k_VTUJJMe5jxdPt0KT3Xm6xc");
            var me = await bot.GetMeAsync();

            var offset = 0;

            while (true)
               {
                var updates = await bot.GetUpdatesAsync(offset);
                foreach (var update in updates)
                {
                    
                    if (update.Message.Type == MessageType.PhotoMessage)
                    {
                        await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                        await Task.Delay(2000);
                        string outputMsg = "چه عکس زیبایی";
                        await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        }
                    
                    else if (update.Message.Type == MessageType.TextMessage)
                    {
                        string msg = update.Message.Text;
                        if (msg.Contains("salam"))
                        {

                            await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                            await Task.Delay(2000);
                            string outputMsg = "سلام عزیزم حالت چطوره؟";
                            await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);

                        }
                        else if (msg.Contains("سلام"))
                        {
                            await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                            await Task.Delay(2000);
                            string outputMsg = "سلام عزیزم حالت چطوره؟";
                            var t = await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        }
                        else if (msg.Contains("چطور"))
                        {
                            await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                            await Task.Delay(2000);
                            string outputMsg = "منم خوبم بلطف شما";
                            var t = await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        }
                        else if (msg.Contains("chetor"))
                        {
                            await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                            await Task.Delay(2000);
                            string outputMsg = "منم خوبم بلطف شما";
                            var t = await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        }
                        else if (msg.Contains("khabar"))
                        {
                            await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                            await Task.Delay(2000);
                            string outputMsg = "سلامتی";
                            var t = await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        }
                        else if (msg.Contains("خبر"))
                        {
                            await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                            await Task.Delay(2000);
                            string outputMsg = "سلامتی";
                            var t = await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        }
                        else if (msg.Contains("کوس"))
                        {
                            await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                            await Task.Delay(2000);
                            string outputMsg = "عیبه حرف بد نزن";
                            var t = await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        }
                        else if (msg.Contains("کس"))
                        {
                            await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                            await Task.Delay(2000);
                            string outputMsg = "عیبه حرف بد نزن";
                            var t = await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        }
                        else if (msg.Contains("بگا"))
                        {
                            await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                            await Task.Delay(2000);
                            string outputMsg = "عیبه حرف بد نزن";
                            var t = await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        }
                        else if (msg.Contains("گایید"))
                        {
                            await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                            await Task.Delay(2000);
                            string outputMsg = "عیبه حرف بد نزن";
                            var t = await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        }
                        else if (msg.Contains("گائید"))
                        {
                            await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                            await Task.Delay(2000);
                            string outputMsg = "عیبه حرف بد نزن";
                            var t = await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        }
                        else if (msg.Contains("بخطا"))
                        {
                            await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                            await Task.Delay(2000);
                            string outputMsg = "عیبه حرف بد نزن";
                            var t = await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        }
                        else if (msg.Contains("به خطا"))
                        {
                            await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                            await Task.Delay(2000);
                            string outputMsg = "عیبه حرف بد نزن";
                            var t = await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        }
                        else
                        {
                            await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                            await Task.Delay(2000);
                            string outputMsg = "از ارسال زیبای شما متشکرم";
                            var t = await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        }
                    }
                    else if (update.Message.Type == MessageType.StickerMessage)
                    {
                        await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                        await Task.Delay(2000);
                        string outputMsg = "این استیکرارو از کجا میاری میگی منم دانلود کنم؟";
                        await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                    }
                    else if (update.Message.Type == MessageType.VoiceMessage)
                    {
                        await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                        await Task.Delay(2000);
                        string outputMsg = "گوش میکنم بعدا نظرمو میگم";
                        await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                        await Task.Delay(6000);
                        await bot.SendTextMessageAsync(update.Message.Chat.Id, "جالب بود");
                    }
                    else
                    {
                        await bot.SendChatActionAsync(update.Message.Chat.Id, ChatAction.Typing);
                        await Task.Delay(2000);
                        string outputMsg = "من تازه به دنیا اومدم همه چی رو که متوجه نمی شم ببخشید";
                        await bot.SendTextMessageAsync(update.Message.Chat.Id, outputMsg);
                    }


                    offset = update.Id + 1;
                }
                
            }
           }
    }
}
