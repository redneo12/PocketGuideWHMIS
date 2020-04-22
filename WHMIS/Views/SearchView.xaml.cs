using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WHMIS.ViewModels;
using WHMIS.Helpers;

namespace WHMIS.Views
{



    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchView : ContentPage
    {
        public List<SearchItem> searchItems;


        public SearchView()
        {
            InitializeComponent();


            searchList.ItemsSource = SearchItemHelper.SearchItem;

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            searchList.ItemsSource = SearchItemHelper.GetSearchResults(e.NewTextValue);
        }



        private void OnSelectedSearchClicked(object sender, EventArgs e)
        {
            var selectedItem = sender as SearchItem;

            //open page of slected item
        }

        private async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        private async void OnHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}