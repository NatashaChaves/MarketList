using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketList.Model
{
    public class ItemLista
    {
        [ForeignKey(typeof(Item))]
        public int ItemId { get; set; }
        [ManyToOne]
        public Item Item { get; set; }
        [ForeignKey(typeof(Listas))]
        public int ListId { get; set; }
        [ManyToOne]
        public Listas Listas { get; set; }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int ProductQaunt { get; set; }
        public DateTime CriarData { get; set; }

    }
}
