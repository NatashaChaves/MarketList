using MarketList.Model;
using MarketList.Service;
using MarketList.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MarketList.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        public ICommand CadastrarItemCommand { get; set; }
        private string _produto;
        public string Produto
        {
            get
            {
                return _produto;
            }

            set
            {
                _produto = value;
                NotifyPropertyChanged("Produto");
            }
        }



        private int _quantidade;
        private Item item;

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }

            set
            {
                _quantidade = value;
                NotifyPropertyChanged("Quantidade");
            }
        }
        public NewItemViewModel()
        {
            CadastrarItemCommand = new Command(CadastrarItem);
        }
        private async void CadastrarItem()
        {

            var item = new Item();
            item.Produto = Produto;
            item.Quantidade = Quantidade;
            ItemService.Insert(item);
            await App.Current.MainPage.Navigation.PushAsync(new ItemPage());

        }
    }

}
