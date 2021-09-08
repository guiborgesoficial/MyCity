using MyCity.Models;
using MyCity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using MyCity.Resources.Enums;

namespace MyCity.ViewModels
{
    public class StoresViewModel
    {
        public String SearchWord { get; set; }
        public ICommand SearchCommand { get; set; }
        public List<Establishment> ListEstablishments { get; set; }

        public StoresViewModel()
        {
            SearchCommand = new Command(Search);

            var AllEstablishment = new EstablishmentServices().GetEstablishments();
            var AllStores = AllEstablishment.Where(a => a.TypeEstablishment == EstablishmentType.StoreType).ToList();

            ListEstablishments = AllStores;
        }
        private void Search()
        {

        }
    }
}
