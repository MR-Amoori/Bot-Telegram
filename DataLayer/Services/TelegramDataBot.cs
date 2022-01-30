using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TelegramDataBot : ITelegramDataBot
    {
        /// <summary>
        /// تعریف در کانستراکتور برای گرفتن یک نمونه از دیتابیس در زمان نمونه سازی
        /// </summary>
        #region Ctor
        TelegramBot_DBEntities db;
        public TelegramDataBot(TelegramBot_DBEntities context)
        {
            db = context;
        }
        #endregion Ctor
        public bool AddItem(Items_TB item)
        {
            try
            {
                db.Items_TB.Add(item);
                return true;
            }
            catch
            {
                return false;

            }
        }

        public bool DeleteCustomer(Items_TB item)
        {
            try
            {
                db.Entry(item).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteItem(int itemId)
        {
            try
            {
                var Item = GetItemById(itemId);
                DeleteCustomer(Item);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Items_TB> GetAllItems()
        {
            return db.Items_TB.ToList();
        }

        public Items_TB GetItemById(int itemId)
        {
            return db.Items_TB.Find(itemId);
        }

        public bool InsertItem(Items_TB item)
        {
            try
            {
                db.Items_TB.Add(item);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateItem(Items_TB item)
        {
            try
            {
                db.Entry(item).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
