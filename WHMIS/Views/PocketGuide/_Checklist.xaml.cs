﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using WHMIS.Data;
using WHMIS.Helpers;
using WHMIS.Models;
using WHMIS.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace WHMIS.Views.PocketGuide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Checklist : ContentPage
    {

        private ChecklistViewModel checklistVM;

        public Checklist()
        {
            InitializeComponent();
            App.Database.UpdateChecklistDate();
            this.checklistVM = new ChecklistViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            this.BindingContext = this.checklistVM;

            checklistView.ItemsSource = this.checklistVM.DataList;

        }


        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //ChecklistItem item = (ChecklistItem)e.Item;

            //item = checklistVM.SelectedItem(item).Result;
            //this.BindingContext = item;

            //Console.WriteLine("~~~~~~~SENDER:" + sender);

        }

        private void OnEntryCompleted(object sender, EventArgs e)
        {
            Entry entry = sender as Entry;

            ChecklistItem item = (ChecklistItem)entry.BindingContext;
            item.Notes = entry.Text;
            Console.WriteLine("item.Notes" + item.Notes);
            checklistVM.UpdateNotes(item);
        }

        private void OnCheckChanged(object sender, CheckedChangedEventArgs e)
        {
            var senderBox = (CheckBox)sender;

            try
            {
                ChecklistItem data = (ChecklistItem)senderBox.BindingContext;

                data.IsChecked = e.Value;
                if (!senderBox.IsChecked)
                {
                    //box has been unchecked, deleted entry
                    data.Date = new DateTime(0001, 01, 01);
                    //data.Notes = "";
                }

                checklistVM.UpdateNotes(data);

                this.BindingContext = checklistVM.DataList;
            }
            catch (Exception)
            {
                Console.WriteLine("!!!!!! _Checklist.OnCheckChanged Was called without user input");
            }


        }
    }
}