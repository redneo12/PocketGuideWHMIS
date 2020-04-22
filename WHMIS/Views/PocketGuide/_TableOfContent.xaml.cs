using WHMIS.Helpers;
using WHMIS.Models;
using WHMIS.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WHMIS.Views.PocketGuide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TableOfContent : ContentPage
    {
        public ObservableCollection<WHMISItem> Items { get; set; }

        public TableOfContent()
        {
            InitializeComponent();

            var itemsource = from s in WHMISHelper.Index
                             orderby s.Id
                             select s;


            MyListView.ItemsSource = itemsource;
            MyListView.IsEnabled = true;
            MyListView.ItemTapped += async (sender, e) =>
            {

                var item = e.Item as WHMISItem;
                if (item == null)
                    return;
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!" + item.TargetType);


                await Navigation.PushAsync((new CarouselPageView(item)));
                //Deselect Item
                ((ListView)sender).SelectedItem = null;
            };
        }





    }
}
