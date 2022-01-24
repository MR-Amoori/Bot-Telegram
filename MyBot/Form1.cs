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
           
        /// <summary>
        /// Run Bot
        /// </summary>
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

                    /// <summary>
                    /// /start Command
                    /// </summary>
                    if (text.Contains("/start"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine($"سلام {from.FirstName} خوش آمدید 🌹");
                        sb.AppendLine("درباره برنامه نویس: /AboutUs");
                        sb.AppendLine("راهنما: /Help");
                        sb.AppendLine("");
                        sb.AppendLine("🤖 @mramoori_bot 🤖");
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                    }

                    /// <summary>
                    /// /AboutUs Command
                    /// </summary>
                    else if (text.Contains("/aboutus"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Mohammadreza Amoori 👤");
                        sb.AppendLine(".NET Developer (C#) 👨🏻‍💻");
                        sb.AppendLine("Phone: 09035170373 📞");
                        sb.AppendLine("Resume: yek.link/mrx10 🌐");
                        sb.AppendLine("Instagram: instagram.com/mr__amoori 📡");
                        sb.AppendLine("Telegram: @Doitik 🚀");
                        sb.AppendLine("Email: Mohamad.reza.amoori99@gmail.com 📧");
                        sb.AppendLine("");
                        sb.AppendLine("🤖 @mramoori_bot 🤖");
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                    }

                    ///<summary>
                    /// /Help Command
                    /// </summary>
                    else if (text.Contains("/help"))
                    {
                        StringBuilder sb=new StringBuilder();
                        sb.AppendLine();
                        sb.AppendLine();
                        sb.AppendLine();
                        sb.AppendLine();
                        bot.SendTextMessageAsync(chatId,sb.ToString());
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load Form
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Closinng Form
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (botThread != null)
            {
                botThread.Abort();
            }

        }

        /// <summary>
        /// Buttun Start And Stop
        /// </summary>
        private void swBtn_StartOrStop_ValueChanged(object sender, EventArgs e)
        {
            // Start
            if (swBtn_StartOrStop.Value == true)
            {
                if (txt_Token.Text == "")
                {
                    MessageBox.Show("توکن خالی است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    swBtn_StartOrStop.Value = false;
                    lbl_Status.Text = "Offline";
                    lbl_Status.ForeColor = Color.Red;
                }

                Token = txt_Token.Text;
                botThread = new Thread(new ThreadStart(runBot));
                botThread.Start();

                if (botThread != null)
                {
                    txt_Token.Enabled = false;
                }
                else if (botThread == null)
                {
                    MessageBox.Show("توکن اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Token.Enabled = true;
                }
            }

            // Stop
            else if (swBtn_StartOrStop.Value == false)
            {

                if (botThread == null)
                {
                    lbl_Status.Text = "Offline";
                    lbl_Status.ForeColor = Color.Red;
                }
                else
                {
                    txt_Token.Enabled = true;
                    botThread.Abort();
                    lbl_Status.Text = "Offline";
                    lbl_Status.ForeColor = Color.Red;
                }
            }
        }
    }
}
