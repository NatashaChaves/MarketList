using MarketList.Database;
using MarketList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MarketList.Service
{
    public static class ListasService
    {
        public static DbAccess<Listas> dbAccess = new DbAccess<Listas>();

        public static void Insert(Listas listas)
        {

            dbAccess.Save(listas);
        }
        public static void Edit(Listas listas)
        {
            dbAccess.Update(listas);
        }

        public static Listas Load(int id)
        {
            return dbAccess.Find(x => x.Id == id);
        }

        public static void Remove(int id)
        {
            dbAccess.Delete(id);
        }

        public static List<Listas> List(Expression<Func<Listas, bool>> predicate)
        {
            return dbAccess.List(predicate).ToList();
        }

        public static List<Listas> ListAll()
        {
            return dbAccess.ListAll().ToList();
        }

    }
}
