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
using Telegram.Bot.Types.InlineKeyboardButtons;
using Api_MyBot;

namespace MyBot
{
    /// <summary>
    /// /////////  راهنما
    /// </summary>

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
        private int progressForBar = 0;

        private static JokApi jok = new JokApi();
        private static DanestaniApi danestani = new DanestaniApi();
        private static DastenKotahApi dastenkotah = new DastenKotahApi();
        private static TavalodApi tavalod = new TavalodApi();

        private static HadisBozorganApi hadis = new HadisBozorganApi();
        private static ZekreAyamHaftehApi zekre = new ZekreAyamHaftehApi();
        private static OghatShareeApi oghatSharee = new OghatShareeApi();

        private static DateApi dateAp = new DateApi();
        private static ShotLinkGenerate shotLink = new ShotLinkGenerate();
        private static InstaDownloderApi instaDownloder = new InstaDownloderApi();
        private static SearchInWikiPediaApi SearchInWikiPedia = new SearchInWikiPediaApi();
        private static NimBahaApi nimBaha = new NimBahaApi();
        private static MourseApi mourse = new MourseApi();
        private static PasswordGenerateApi password = new PasswordGenerateApi();
        private static FindNumberApi findNumber = new FindNumberApi();

        public Form1()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Load Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            mainKeyboardMarkup = new ReplyKeyboardMarkup();
            KeyboardButton[] row1 = { new KeyboardButton("🔧 " + "ابزار های ربات" + " 🔧") };
            KeyboardButton[] row2 = { new KeyboardButton("📒 " + "راهنما" + " 📒"), new KeyboardButton("👨🏻‍💻 " + "درباره برنامه نویس" + " 👨🏻‍💻") };
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
                txt_ChatId.Enabled = true;
                btn_SendToChatId.Enabled = true;
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
                    MessageBox.Show("مشکل در اتصال به توکن", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

                        InlineKeyboardMarkup inline = new InlineKeyboardMarkup();

                        InlineKeyboardUrlButton[] row2 =
                        {
                            new InlineKeyboardUrlButton("🌐 رزومه 🌐","https://yek.link/mrx10")
                        };

                        InlineKeyboardUrlButton[] row3 =
                        {
                            new InlineKeyboardUrlButton("📡 اینستاگرام 📡","https://instagram.com/mr__amoori"),
                            new InlineKeyboardUrlButton("🚀 تلگرام 🚀","https://t.me/doitik"),
                        };

                        InlineKeyboardUrlButton[] row4 =
                        {
                            new InlineKeyboardUrlButton("📧 ایمیل 📧", "Mohamad.reza.amoori99@gmail.com")
                        };

                        inline.InlineKeyboard = new InlineKeyboardUrlButton[][] { row2, row3, row4 };

                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0, inline);
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
                    /// Tools ابزارها
                    /// </summary>
                    else if (text.Contains("ابزار های ربات"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("ابزار مورد نظر خود را انتخاب کنید 🔧");

                        ReplyKeyboardMarkup toolsKeyboard = new ReplyKeyboardMarkup();
                        KeyboardButton[] row1 = { new KeyboardButton("🎲 سرگرمی 🎲"), new KeyboardButton("☀️ روزانه ☀️") };
                        KeyboardButton[] row2 = { new KeyboardButton("🔗 کوتاه کننده لینک 🔗"), new KeyboardButton("📍 دانلودر 📍") };
                        KeyboardButton[] row3 = { new KeyboardButton("📎 ساخت لینک نیم بها 📎"), new KeyboardButton("✂️ کد مورسی ✂️") };
                        KeyboardButton[] row4 = { new KeyboardButton("🔒 پسورد ساز 🔒"), new KeyboardButton("🔎 سرچ مطلب 🔍") };
                        KeyboardButton[] row5 = { new KeyboardButton("☎️ شماره یاب ☎️"), new KeyboardButton("📞 اطلاعات شماره 📞") };
                        KeyboardButton[] row6 = { new KeyboardButton("◀️ " + "بازگشت" + " ◀️") };
                        toolsKeyboard.Keyboard = new KeyboardButton[][] { row1, row2, row3, row4, row5, row6 };

                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0, toolsKeyboard);
                    }


                    ///<summary>
                    /// شماره تلفن
                    /// </summary>
                    #region شماره تلفن

                    else if (text.Contains("☎️ شماره یاب ☎️"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("نوع جستجو را انتخاب کنید");
                        ReplyKeyboardMarkup toolsKeyboard = new ReplyKeyboardMarkup();
                        KeyboardButton[] row1 = { new KeyboardButton("🆔 آیدی 🆔"), new KeyboardButton("🔢 آیدی عددی 🔢") };
                        KeyboardButton[] row2 = { new KeyboardButton("◀️ " + "بازگشت" + " ◀️") };
                        toolsKeyboard.Keyboard = new KeyboardButton[][] { row1, row2 };
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, default, toolsKeyboard);
                    }

                    else if (text.Contains("🆔 آیدی 🆔"))
                    {
                        StringBuilder sb = new StringBuilder(); ;
                        sb.AppendLine("آیدی مورد نظر را طبق فرمت زیر ارسال کنید.");
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                        StringBuilder sb2 = new StringBuilder();
                        sb2.AppendLine("آیدی:@doitik");
                        bot.SendTextMessageAsync(chatId, sb2.ToString());
                    }

                    else if (text.Contains("آیدی:"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(findNumber.FindNumberByUserName(text));
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                    }

                    else if (text.Contains("🔢 آیدی عددی 🔢"))
                    {
                        StringBuilder sb = new StringBuilder(); ;
                        sb.AppendLine("آیدی عددی مورد نظر را طبق فرمت زیر ارسال کنید.");
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                        StringBuilder sb2 = new StringBuilder();
                        sb2.AppendLine("آیدی عددی:53521545");
                        bot.SendTextMessageAsync(chatId, sb2.ToString());
                    }

                    else if (text.Contains("آیدی عددی:"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(findNumber.FindNumberById(text));
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                    }

                    ///<summary>
                    /// اطلاعات شماره
                    /// </summary>
                    else if (text.Contains("📞 اطلاعات شماره 📞"))
                    {
                        StringBuilder sb = new StringBuilder(); ;
                        sb.AppendLine("شماره تلفن مورد نظر را طبق فرمت زیر ارسال کنید.");
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                        StringBuilder sb2 = new StringBuilder();
                        sb2.AppendLine("شماره تلفن شخص:09120000000");
                        bot.SendTextMessageAsync(chatId, sb2.ToString());
                    }

                    else if (text.Contains("شماره تلفن شخص:"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(findNumber.InformationNumber(text));
                        bot.SendTextMessageAsync(chatId, sb.ToString());

                    }

                    #endregion شماره تلفن


                    ///<summary>
                    /// پسورد ساز
                    /// </summary>
                    #region پسورد ساز

                    else if (text.Contains("پسورد ساز"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine($"رمز ساخته شده: {password.PasswordGenerate()}");
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                    }

                    #endregion پسورد ساز


                    ///<summary>
                    /// کد مورسی
                    /// </summary>
                    #region کد مورسی

                    else if (text.Contains("✂️ کد مورسی ✂️"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("قابلیت مورد نظر را انتخاب کنید");

                        ReplyKeyboardMarkup toolsKeyboard = new ReplyKeyboardMarkup();
                        KeyboardButton[] row1 = { new KeyboardButton("🔐 کد گذاری 🔐"), new KeyboardButton("🔓 بازگشایی 🔓") };
                        KeyboardButton[] row2 = { new KeyboardButton("❔ کد مورس چیست ❔") };
                        KeyboardButton[] row5 = { new KeyboardButton("◀️ " + "بازگشت" + " ◀️") };
                        toolsKeyboard.Keyboard = new KeyboardButton[][] { row1, row2, row5 };

                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0, toolsKeyboard);


                    }
                    else if (text.Contains("کد مورس چیست"))
                    {
                        StringBuilder sb = new StringBuilder(); ;
                        sb.AppendLine("روشی برای انتقال پیام و اطلاعات است که در آن از یک رشته نشانه‌های بلند و کوتاهِ استاندارد به نام خط و نقطه استفاده می‌شود و همچنین در تلگراف نیز بکار گرفته می‌شود.");
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                    }

                    else if (text.Contains("کد گذاری"))
                    {
                        StringBuilder sb = new StringBuilder(); ;
                        sb.AppendLine("پیام زیر را کپی و متن خود را جهت کد گذاری جایگزین عبارت 'متن مورد نظر' کنید.");
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                        StringBuilder sb2 = new StringBuilder();
                        sb2.AppendLine("کد مورسی:متن مورد نظر");
                        bot.SendTextMessageAsync(chatId, sb2.ToString());
                    }

                    else if (text.Contains("کد مورسی:"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("کد مورسی شما:");
                        sb.AppendLine(mourse.MurosePersianGenerate(text));
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                    }

                    else if (text.Contains("🔓 بازگشایی 🔓"))
                    {
                        StringBuilder sb = new StringBuilder(); ;
                        sb.AppendLine("پیام زیر را کپی و متن خود را جهت بازگشایی جایگزین عبارت 'متن مورد نظر' کنید.");
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                        StringBuilder sb2 = new StringBuilder();
                        sb2.AppendLine("کد مورسی جهت بازگشایی:متن مورد نظر");
                        bot.SendTextMessageAsync(chatId, sb2.ToString());
                    }

                    else if (text.Contains("کد مورسی جهت بازگشایی:"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("کد مورسی رمزنگاری شده شما: " + mourse.MurosePersianReverse(text));
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                    }

                    #endregion کد مورسی



                    ///<summary>
                    /// دانلودر
                    /// </summary>
                    #region دانلودر

                    else if (text.Contains("دانلودر"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("دانلودر مورد نظر خود را انتخاب کنید 🔗");
                        ReplyKeyboardMarkup toolsKeyboard = new ReplyKeyboardMarkup();
                        KeyboardButton[] row1 = { new KeyboardButton("🔹 اینستاگرام 🔹"), new KeyboardButton("🔸 یوتیوب 🔸") };
                        KeyboardButton[] row2 = { new KeyboardButton("◀️ " + "بازگشت" + " ◀️") };
                        toolsKeyboard.Keyboard = new KeyboardButton[][] { row1, row2 };
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0, toolsKeyboard);
                    }

                    else if (text.Contains("اینستاگرام"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("لینک پست مورد نظر را ارسال کنید 🔗");
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                    }

                    else if (text.Contains("https://www.instagram.com/"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine($"لینک دانلود : {instaDownloder.Download(text)}");
                        ReplyKeyboardMarkup toolsKeyboard = new ReplyKeyboardMarkup();
                        KeyboardButton[] row1 = { new KeyboardButton("◀️ " + "بازگشت" + " ◀️") };
                        toolsKeyboard.Keyboard = new KeyboardButton[][] { row1 };
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0, toolsKeyboard);
                    }

                    else if (text.Contains("یوتیوب"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("این قابلیت نیاز به تعمیر دارد 🪒");
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);

                    }

                    #endregion دانلودر

                    ///<summary>
                    /// سرچ مطلب
                    /// </summary>
                    #region سرچ مطلب
                    else if (text.Contains("سرچ مطلب"))
                    {
                        StringBuilder sb = new StringBuilder();
                        StringBuilder sb2 = new StringBuilder();
                        //sb.AppendLine(@"پیام زیر را کپی و لینک خورا جایگیزن کلمه 'متن جستجو' کنید و ارسال کنید.");
                        sb.AppendLine("این قابلیت نیاز به تعمیر دارد 🪒");
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                        //sb2.AppendLine("سرچ:متن جوستجو");
                        //bot.SendTextMessageAsync(chatId, sb2.ToString());
                    }

                    //else if (text.Contains("سرچ:"))
                    //{
                    //    StringBuilder sb=new StringBuilder();
                    //    sb.AppendLine("نتیجه: " + SearchInWikiPedia.Search(text));
                    //    bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                    //}

                    #endregion سرچ مطلب

                    ///<summary>
                    /// لینک نیم بها
                    /// </summary>
                    #region لینک نیم بها

                    else if (text.Contains("لینک نیم بها"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("آدرس لینک دانلود خود را برای نیم بها کردن جایگزین عبارت 'لینک مورد نظر' کنید. مانند نمونه زیر");
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                        StringBuilder sb2 = new StringBuilder();
                        sb2.AppendLine("نیم بها:لینک مورد نظر");
                        bot.SendTextMessageAsync(chatId, sb2.ToString());
                    }

                    else if (text.Contains("نیم بها:"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("لینک شما لینک دانلود نیست");
                        //sb.AppendLine($"لینک نیم بهای شما: {nimBaha.NimBaha(text)}");
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                    }



                    #endregion لینک نیم بها


                    ///<summary>
                    /// کوتاه کننده لینک
                    /// </summary>
                    #region کوتاه کننده لینک

                    else if (text.Contains("کوتاه کننده لینک"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("آدرس خود را برای کوتاه کردن وارد کنید. مانند نمونه زیر :\n" + " https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png");
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                    }

                    else if (text.Contains("https://"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(shotLink.ShortLink(text));
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                    }

                    #endregion کوتاه کننده لینک

                    /// <summary>
                    /// سرگرمی
                    /// </summary>
                    #region سرگرمی
                    else if (text.Contains("سرگرمی"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("سرگرمی مورد نظر خود را انتخاب کنید 🧩");
                        ReplyKeyboardMarkup rkm = new ReplyKeyboardMarkup();
                        KeyboardButton[] row1 = { new KeyboardButton("🎭 جوک 🎭"), new KeyboardButton("🎬 دانستنی 🎬") };
                        KeyboardButton[] row2 = { new KeyboardButton("🎂 جزئیات تولد 🎂"), new KeyboardButton("📚 داستان کوتاه 📚") };
                        KeyboardButton[] row3 = { new KeyboardButton("◀️ " + "بازگشت" + " ◀️") };
                        rkm.Keyboard = new KeyboardButton[][] { row1, row2, row3 };
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0, rkm);
                    }

                    ///<summary>
                    /// جوک
                    /// </summary>
                    #region جوک
                    else if (text.Contains("🎭 جوک 🎭"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("دسته مورد نظر خود را انتخاب کنید 🗂");
                        ReplyKeyboardMarkup rkm = new ReplyKeyboardMarkup();
                        KeyboardButton[] row1 = { new KeyboardButton("🤹🏻‍♂️ جوک طنز 🤹🏻‍♂️"), new KeyboardButton("📖 خاطرات طنز 📖") };
                        KeyboardButton[] row2 = { new KeyboardButton("♨️ پ ن پ ♨️"), new KeyboardButton("👀 الکی مثلا 👀") };
                        KeyboardButton[] row3 = { new KeyboardButton("◀️ " + "بازگشت" + " ◀️") };
                        rkm.Keyboard = new KeyboardButton[][] { row1, row2, row3 };
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0, rkm);
                    }


                    else if (text.Contains("جوک طنز"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(jok.Jok());
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                    }

                    else if (text.Contains("خاطرات طنز"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(jok.Khaterat());
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                    }

                    else if (text.Contains("الکی مثلا"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(jok.AlakiMasalan());
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                    }

                    else if (text.Contains("پ ن پ"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(jok.PaNaPa());
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                    }

                    #endregion جوک


                    ///<summary>
                    /// دانستنی
                    /// </summary>
                    else if (text.Contains("دانستنی"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(danestani.Danestani());
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                    }

                    else if (text.Contains("داستان کوتاه"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(dastenkotah.Dastan());
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                    }

                    else if (text.Contains("جزئیات تولد"))
                    {
                        StringBuilder sb = new StringBuilder();
                        StringBuilder sb2 = new StringBuilder();
                        //  sb.AppendLine("این قابلیت نیاز به تعمیر دارد 🪒");
                        sb.AppendLine("پیام زیر را کپی و اطلاعات خورا جایگیزن اعداد آن کنید و ارسال کنید.");
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                        sb2.AppendLine("سال: 1383");
                        sb2.AppendLine("ماه: 06");
                        sb2.AppendLine("روز: 02");
                        bot.SendTextMessageAsync(chatId, sb2.ToString(), ParseMode.Html);
                    }

                    else if (text.Contains("سال") && text.Contains("ماه") && text.Contains("روز"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(tavalod.Tavalod3(text));
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html);
                    }

                    #endregion سرگرمی


                    ///<summary>
                    /// روزانه
                    /// </summary>
                    #region روزانه

                    else if (text.Contains("روزانه"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(dateAp.LongDate());
                        sb.AppendLine("");
                        sb.AppendLine("انتخاب کنید 🗂");
                        ReplyKeyboardMarkup rkm = new ReplyKeyboardMarkup();
                        KeyboardButton[] row1 = { new KeyboardButton("📝 حدیث بزرگان 📝"), new KeyboardButton("🕌 اوقات شرعی 🕌") };
                        KeyboardButton[] row2 = { new KeyboardButton("📿 ذکر ایام هفته 📿") };
                        KeyboardButton[] row3 = { new KeyboardButton("◀️ " + "بازگشت" + " ◀️") };
                        rkm.Keyboard = new KeyboardButton[][] { row1, row2, row3 };
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0, rkm);
                    }

                    else if (text.Contains("حدیث بزرگان"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(hadis.Hadis());
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                    }

                    else if (text.Contains("ذکر ایام هفته"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(zekre.Zekr());
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                    }

                    else if (text.Contains("اوقات شرعی"))
                    {
                        StringBuilder sb = new StringBuilder();
                        //   sb.AppendLine("این قابلیت نیاز به تعمیر دارد 🪒");

                        sb.AppendLine("نام شهر مورد نظر را طبق فرمت زیر ارسال کنید.");
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                        StringBuilder sb2 = new StringBuilder();
                        sb2.AppendLine("شهر:خرمشهر");
                        bot.SendTextMessageAsync(chatId, sb.ToString(), ParseMode.Html, default, default, 0);
                        bot.SendTextMessageAsync(chatId, sb2.ToString());
                    }

                    else if (text.Contains("شهر:"))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine(oghatSharee.Oghat(text));
                        bot.SendTextMessageAsync(chatId, sb.ToString());
                    }

                    #endregion روزانه



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
                txt_ChatId.Enabled = false;
                btn_SendToChatId.Enabled = false;

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
                    progressBarItem1.Value = 50;

                    /*   InputFileStream imageFile = System.IO.File.Open(txt_FilePath.Text, System.IO.FileMode.Open);
                    bot.SendPhotoAsync(chatId, new InputOnlineFile(imageFile.Content, "Bot.jpg"), txt_Message.Text, ParseMode.Html);
                */
                    System.IO.FileStream imageFile = System.IO.File.Open(txt_FilePath.Text, System.IO.FileMode.Open);
                    bot.SendPhotoAsync(chatId, new FileToSend("Bot.png", imageFile), txt_Message.Text);

                    progressBarItem1.Value = 100;
                }

                catch (IOException)
                {
                    MessageBox.Show("صبر کنید تا پروسه ارسال فایل به اتمام برسد.", "خطا", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("فایلی انتخاب نکرده اید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    progressBarItem1.Value = 0;
                    progressForBar = 0;
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
                    progressForBar = 50;
                    progressBarItem1.Value = progressForBar;
                    //InputFileStream videoFile = System.IO.File.Open(txt_FilePath.Text, System.IO.FileMode.Open);
                    //bot.SendPhotoAsync(chatId, new InputOnlineFile(videoFile.Content, "mr.mp4"), txt_Message.Text, ParseMode.Html);
                    FileStream imageFile = System.IO.File.Open(txt_FilePath.Text, System.IO.FileMode.Open);
                    bot.SendVideoAsync(chatId, new FileToSend("Bot.mp4", imageFile), default, default, default, txt_Message.Text);
                    progressForBar = 100;
                    progressBarItem1.Value = progressForBar;
                }

                catch (IOException)
                {
                    MessageBox.Show("صبر کنید تا پروسه ارسال فایل به اتمام برسد.", "خطا", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("فایلی انتخاب نکرده اید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    progressForBar = 0;
                    progressBarItem1.Value = progressForBar;
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
            try
            {
                FileStream imageFile = System.IO.File.Open(txt_FilePath.Text, System.IO.FileMode.Open);
                bot.SendVideoAsync(txt_Channel.Text, new FileToSend("Bot.mp4", imageFile), default, default, default, txt_Message.Text);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("فایلی انتخاب نکرده اید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                FileStream imageFile = System.IO.File.Open(txt_FilePath.Text, System.IO.FileMode.Open);
                bot.SendPhotoAsync(txt_Channel.Text, new FileToSend("Bot.png", imageFile), txt_Message.Text);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("فایلی انتخاب نکرده اید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ChatId_MouseClick(object sender, MouseEventArgs e)
        {
            txt_ChatId.Text = "";
        }

        private void btn_SendToChatId_Click(object sender, EventArgs e)
        {
            try
            {
                var chattid = Convert.ToInt64(txt_ChatId.Text);
            bot.SendTextMessageAsync(chattid,txt_Message.Text);
            }
            catch
            {
                MessageBox.Show("خطا در چت آیدی");

            }

        }
    }
}
