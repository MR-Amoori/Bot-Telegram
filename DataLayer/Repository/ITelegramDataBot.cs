using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface ITelegramDataBot
    {
        List<Items_TB> GetAllItems();
        Items_TB GetItemById(int itemId);
        bool AddItem(Items_TB item);
        bool InsertItem(Items_TB item);
        bool UpdateItem(Items_TB item);
        bool DeleteItem(int itemId);
        bool DeleteCustomer(Items_TB item);
    }
}
