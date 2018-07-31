using MarketList.Database;
using MarketList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MarketList.Service
{
    public static class ItemService
    {
        public static DbAccess<Item> dbAccess = new DbAccess<Item>();

        public static void Insert(Item item)
        {

            dbAccess.Save(item);
        }
        public static void Edit(Item item)
        {
            dbAccess.Update(item);
        }

        public static Item Load(int id)
        {
            return dbAccess.Find(x => x.Id == id);
        }

        public static void Remove(int id)
        {
            dbAccess.Delete(id);
        }

        public static List<Item> List(Expression<Func<Item, bool>> predicate)
        {
            return dbAccess.List(predicate).ToList();
        }

        public static List<Item> ListAll()
        {
            return dbAccess.ListAll().ToList();
        }


    }
}
