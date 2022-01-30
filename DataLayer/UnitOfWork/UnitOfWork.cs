using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork : IDisposable
    {
        TelegramBot_DBEntitiesss db = new TelegramBot_DBEntitiesss(); // DataBase

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

        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
