using MarketList.Model;
using MarketList.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MarketList.ViewModels
{
    public class ListViewModel : BaseViewModel
    {
        public ObservableCollection<Listas> Listas { get; set; }
        public ListViewModel()
        {
            Listas = new ObservableCollection<Listas>(ListasService.ListAll());

        }
    }
}
