using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork
    {
        TelegramBot_DBEntities db = new TelegramBot_DBEntities(); // DataBase

        private TelegramDataBot _TelegramDataBot;
        public TelegramDataBot TelegramDataBott
        {
            get
            {
                if (_TelegramDataBot == null)
                {
                    _TelegramDataBot = new TelegramDataBot(db);
                }
                return _TelegramDataBot;
            }
        }
    }
}
