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
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using System.IO;

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
        private ReplyKeyboardMarkup mainKeyboardMarkup;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load Form
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            mainKeyboardMarkup = new ReplyKeyboardMarkup();
            KeyboardButton[] row1 = { new KeyboardButton("📒 " + "راهنما" + " 📒") };
            KeyboardButton[] row2 = { new KeyboardButton("👨🏻‍💻 " + "درباره برنامه نویس" + " 👨🏻‍💻") };
            mainKeyboardMarkup.Keyboard = new KeyboardButton[][] { row1, row2 };
        }


        /// <summary>
        /// Run Bot
        /// </summary>
        #region StartBot
        void runBot()
        {
            bot = new TelegramBotClient(Token);

            this.Invoke(new Action(() =>
            {
                lbl_Status.Text = "Online";
                lbl_Status.ForeColor = Color.LightGreen;
                txt_Message.Enabled = true;
                txt_FilePath.Enabled = true;
                btn_Send.Enabled = true;
                btn_SelectFile.Enabled = true;
                btn_SendPhoto.Enabled = true;
                btn_SendVideo.Enabled = true;
                btn_DelPath.Enabled = true;
                txt_Channel.Enabled = true;
                btn_SendMessageToChannel.Enabled = true;
                btn_SendPhotoToChannel.Enabled = true;
                btn_SendVideoToChannel.Enabled = true;
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

                    swBtn_StartOrStop.Invoke(new Action(() =>
                    {
                        swBtn_StartOrStop.Value = false;
                    }));
                    txt_Token.Enabled = true;
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
                        sb.AppendLine("درباره برنامه نویس : /AboutUs");
                        sb.AppendLine("راهنما : /Help");
                        sb.AppendLine("");
                        sb.AppendLine("🤖 @mramoori_bot 🤖");
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0, mainKeyboardMarkup);
                    }

                    /// <summary>
                    /// /AboutUs Command
                    /// </summary>
                    else if (text.Contains("/aboutus") || text.Contains("درباره برنامه نویس"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Mohammad Reza Amoori  👤");
                        sb.AppendLine("");
                        sb.AppendLine(".NET Developer (C#)  👨🏻‍💻");
                        sb.AppendLine("");
                        sb.AppendLine("Phone: 09035170373  📞");
                        sb.AppendLine("");
                        sb.AppendLine("Resume: yek.link/mrx10  🌐");
                        sb.AppendLine("");
                        sb.AppendLine("Instagram: instagram.com/mr__amoori  📡");
                        sb.AppendLine("");
                        sb.AppendLine("Telegram: @Doitik  🚀");
                        sb.AppendLine("");
                        sb.AppendLine("Email: Mohamad.reza.amoori99@gmail.com  📧");
                        sb.AppendLine("");
                        sb.AppendLine("🤖 @mramoori_bot 🤖");

                        ReplyKeyboardMarkup rkm = new ReplyKeyboardMarkup();
                        KeyboardButton[] row1 = { new KeyboardButton("◀️ " + "بازگشت" + " ◀️") };
                        rkm.Keyboard = new KeyboardButton[][] { row1 };


                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0, rkm);
                    }

                    ///<summary>
                    /// /Help Command
                    /// </summary>
                    else if (text.Contains("/help") || text.Contains("راهنما"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("حوضه راهنمایی را مشخص کنید.");

                        ReplyKeyboardMarkup HelpKeyboardMarkup = new ReplyKeyboardMarkup();
                        KeyboardButton[] row1 = { new KeyboardButton("🔧 " + "دستورات اولیه" + " 🔧"), new KeyboardButton("hele") };
                        KeyboardButton[] row2 = { new KeyboardButton("◀️ " + "بازگشت" + " ◀️") };
                        HelpKeyboardMarkup.Keyboard = new KeyboardButton[][] { row1, row2 };

                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0, HelpKeyboardMarkup);
                    }

                    ///<summary>
                    /// back بازگشت
                    /// </summary>
                    else if (text.Contains("بازگشت"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("به منوی اصلی بازگشتید" + " ◀️");
                        sb.AppendLine("از منوی پایین انتخاب کنید " + "👇🏻");
                        sb.AppendLine("");
                        sb.AppendLine("🤖 @mramoori_bot 🤖");
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0, mainKeyboardMarkup);
                    }


                    ///<summary>
                    ///پیام نا خوانا
                    /// </summary>
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("متوجه نشدیم");
                        sb.AppendLine("از منوی پایین انتخاب کنید " + "👇🏻");
                        sb.AppendLine("");
                        sb.AppendLine("🤖 @mramoori_bot 🤖");
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0, mainKeyboardMarkup);
                    }

                    ///<summary>
                    /// نوشتن یک خط در دیتاگریدویو
                    /// </summary>
                    dgvReport.Invoke(new Action(() =>
                    {
                        dgvReport.Rows.Add(chatId, from.Username, from.FirstName + " " + from.LastName, text, up.Message.MessageId, up.Message.Date.ToString("yyyy/MM/dd - HH:mm:ss"));
                    }));

                }
            }
        }
        #endregion StartBot

        /// <summary>
        /// Closinng Form
        /// </summary>
        #region Form_Closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (botThread != null)
            {
                botThread.Abort();
            }

        }

        #endregion Form_Closing

        /// <summary>
        /// Buttun Start And Stop
        /// </summary>
        #region SwitchButton_Start-Or-Stop
        private void swBtn_StartOrStop_ValueChanged(object sender, EventArgs e)
        {
            // Start
            if (swBtn_StartOrStop.Value == true)
            {
                if (txt_Token.Text == "")
                {
                    MessageBox.Show("توکن خالی است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    swBtn_StartOrStop.Value = false;
                }

                if (txt_Token.Text != "")
                {
                    txt_Token.Enabled = false;
                    Token = txt_Token.Text;
                    botThread = new Thread(new ThreadStart(runBot));
                    botThread.Start();
                }
                else if (botThread == null)
                {
                    MessageBox.Show("توکن اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    swBtn_StartOrStop.Invoke(new Action(() =>
                    {
                        swBtn_StartOrStop.Value = false;
                    }));
                    txt_Token.Enabled = true;
                }
            }

            // Stop
            else if (swBtn_StartOrStop.Value == false)
            {
                txt_Message.Enabled = false;
                txt_FilePath.Enabled = false;
                btn_Send.Enabled = false;
                btn_SelectFile.Enabled = false;
                btn_SendPhoto.Enabled = false;
                btn_SendVideo.Enabled = false;
                btn_DelPath.Enabled = false;
                txt_Channel.Enabled = false;
                btn_SendMessageToChannel.Enabled = false;
                btn_SendPhotoToChannel.Enabled = false;
                btn_SendVideoToChannel.Enabled = false;

                if (botThread == null)
                {
                    lbl_Status.Invoke(new Action(() =>
                    {
                        lbl_Status.Text = "Offline";
                        lbl_Status.ForeColor = Color.Red;
                    }));
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
        #endregion SwitchButton_Start-Or-Stop


        /// <summary>
        /// Send Message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                int chatID = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                bot.SendTextMessageAsync(chatID, txt_Message.Text, ParseMode.Html);
            }
        }

        /// <summary>
        /// Select File For Send
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txt_FilePath.Text = openFile.FileName;

            }
        }

        /// <summary>
        /// Send Photo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SendPhoto_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                try
                {
                    int chatId = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());

                    /*   InputFileStream imageFile = System.IO.File.Open(txt_FilePath.Text, System.IO.FileMode.Open);
                    bot.SendPhotoAsync(chatId, new InputOnlineFile(imageFile.Content, "Bot.jpg"), txt_Message.Text, ParseMode.Html);
                */
                    System.IO.FileStream imageFile = System.IO.File.Open(txt_FilePath.Text, System.IO.FileMode.Open);
                    bot.SendPhotoAsync(chatId, new FileToSend("Bot.png", imageFile), txt_Message.Text);

                }
                catch (ArgumentException)
                {
                    MessageBox.Show("فایلی انتخاب نکرده اید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        /// <summary>
        /// Send Video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SendVideo_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                try
                {
                    int chatId = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                    //InputFileStream videoFile = System.IO.File.Open(txt_FilePath.Text, System.IO.FileMode.Open);
                    //bot.SendPhotoAsync(chatId, new InputOnlineFile(videoFile.Content, "mr.mp4"), txt_Message.Text, ParseMode.Html);
                    FileStream imageFile = System.IO.File.Open(txt_FilePath.Text, System.IO.FileMode.Open);
                    bot.SendPhotoAsync(chatId, new FileToSend("Bot.mp4", imageFile), txt_Message.Text);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("فایلی انتخاب نکرده اید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// emptying TextBox File Path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            txt_FilePath.Text = "";
        }

        /// <summary>
        /// Developer information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mohammad Reza Amoori  👤 \n.NET Developer (C#)  👨🏻‍💻 \nPhone: 09035170373  📞 \nResume: yek.link/mrx10  🌐 \nInstagram: instagram.com/mr__amoori  📡 \nTelegram: @Doitik  🚀 \nEmail: Mohamad.reza.amoori99@gmail.com  📧", "Developer information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Send Message To Channel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SendMessageToChannel_Click(object sender, EventArgs e)
        {
            bot.SendTextMessageAsync(txt_Channel.Text, txt_Message.Text, ParseMode.Html);
        }

        /// <summary>
        /// Send Video To Channel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SendVideoToChannel_Click(object sender, EventArgs e)
        {
            //InputFileStream videoFile = System.IO.File.Open(txt_FilePath.Text, System.IO.FileMode.Open);
            //bot.SendPhotoAsync(txt_Channel.Text, new InputOnlineFile(videoFile.Content, "mr.mp4"), txt_Message.Text, ParseMode.Html);
            FileStream imageFile = System.IO.File.Open(txt_FilePath.Text, System.IO.FileMode.Open);
            bot.SendVideoAsync(txt_Channel.Text, new FileToSend("Bot.mp4", imageFile), default, default, default, txt_Message.Text);
        }

        /// <summary>
        /// Send Photo To Channel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SendPhotoToChannel_Click(object sender, EventArgs e)
        {
            //InputFileStream imageFile = System.IO.File.Open(txt_FilePath.Text, System.IO.FileMode.Open);
            //bot.SendPhotoAsync(txt_Channel.Text, new InputOnlineFile(imageFile.Content, "Bot.jpg"), txt_Message.Text, ParseMode.Html);

            FileStream imageFile = System.IO.File.Open(txt_FilePath.Text, System.IO.FileMode.Open);
            bot.SendPhotoAsync(txt_Channel.Text, new FileToSend("Bot.png", imageFile), txt_Message.Text);
        }
    }
}
