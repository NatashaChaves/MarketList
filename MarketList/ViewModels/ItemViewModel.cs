using MarketList.Model;
using MarketList.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace MarketList.ViewModels
{
   public class ItemViewModel : BaseViewModel
    {
        public ICommand AdicionarCommand { get; set; }
        public ObservableCollection<Item> DadosAgrupados { get; set; }
        public ObservableCollection<Item> Items { get; set; }
        public ItemViewModel()
        {
            Items = new ObservableCollection<Item>(ItemService.ListAll());

        }


    }
}
