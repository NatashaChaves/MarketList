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
    public class NewListViewModel : BaseViewModel
    {
        public ICommand CadastrarCommand { get; set; }
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
                NotifyPropertyChanged("Nome");
            }
        }



        private DateTime _data;
        public DateTime Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
                NotifyPropertyChanged("Data");
            }
        }
        public NewListViewModel()
        {
            CadastrarCommand = new Command(Cadastrar);
        }
        private async void Cadastrar()
        {
            var lista = new Listas();
            lista.Nome = Nome;
            lista.Data = Data;
            ListasService.Insert(lista);
            await App.Current.MainPage.Navigation.PushAsync(new ListPage());

        }

    }
}
