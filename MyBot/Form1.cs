using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Telegram.Bot;

namespace MyBot
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Token Bot
        /// </summary>
        private static string Token = "";
        private Thread botThread;
        private TelegramBotClient bot;
        private Telegram.Bot.Types.Update[] update;
        void runBot()
        {
            bot = new TelegramBotClient(Token);

            this.Invoke(new Action(() =>
            {
                lbl_Status.Text = "Online";
                lbl_Status.ForeColor = Color.LightGreen;
            }));

            int offset = 0;

            while (true)
            {
                try
                {
                    update = bot.GetUpdatesAsync(offset).Result;
                }
                catch (AggregateException)
                {
                    MessageBox.Show("توکن اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    botThread.Abort();
                }

                foreach (var up in update)
                {
                    offset = up.Id + 1;

                    if (up.Message == null)
                        continue;

                    var text = up.Message.Text.ToLower();
                    var from = up.Message.From;
                    var chatId = up.Message.Chat.Id;

                    if (text.Contains("/start"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine($"خوش آمدید ♥ {from.Username}");
                        sb.AppendLine("میتوانید از امکاناتی که این بات در اختیار شما قرار میدهد استفاده کنید");
                        sb.AppendLine("درباره ما: /AboutUs");
                        sb.AppendLine("تماس با ما: /ContactUs");
                        sb.AppendLine("آدرس ما: /Address");
                        sb.AppendLine("🖥 @mramoori_bot");
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                    }

                    else if (text.Contains("/aboutus"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("محمدرضا عموری هستم برنامه نویس دات نت (#C)");
                        sb.AppendLine("🖥 @mramoori_bot");
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                    }

                }

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (botThread!=null)
            {
                botThread.Abort();
            }
            
        }
        /*
        private void btn_Start_Click(object sender, EventArgs e)
        {

            Token = txt_Token.Text;
            botThread = new Thread(new ThreadStart(runBot));
            botThread.Start();
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (txt_Token.Text == "")
            {
                MessageBox.Show("توکن اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (botThread == null)
                {
                    MessageBox.Show("توکن اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    botThread.Abort();
                    lbl_Status.Text = "Offline";
                    lbl_Status.ForeColor = Color.Red;
                }

            }
        }
        */ // ***********
        private void swBtn_StartOrStop_ValueChanged(object sender, EventArgs e)
        {
            if (swBtn_StartOrStop.Value==true)
            {
                Token = txt_Token.Text;
                botThread = new Thread(new ThreadStart(runBot));
                botThread.Start();
            }

            else if (true)
            {
                if (txt_Token.Text == "")
                {
                    MessageBox.Show("توکن اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (botThread == null)
                    {
                        MessageBox.Show("توکن اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        botThread.Abort();
                        lbl_Status.Text = "Offline";
                        lbl_Status.ForeColor = Color.Red;
                    }

                }
            }

        }
    }
}
