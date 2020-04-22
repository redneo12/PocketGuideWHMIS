using WHMIS.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WHMIS.Helpers
{
    public class WHMISHelper
    {
        public static ObservableCollection<WHMISItem> Index { get; set; }

        static WHMISHelper()
        {
            Index = new ObservableCollection<WHMISItem>();


            #region WHMIS
            Index.Add(new WHMISItem
            {
                Id = 1,
                Title = "Introduction",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageIntroduction)
            });
            Index.Add(new WHMISItem
            {
                Id = 2,
                Title = "WHMIS - Acronyms",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageWhmisAcronym)
            });
            Index.Add(new WHMISItem
            {
                Id = 3,
                Title = "WHMIS - 3 Main Elements",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageWhmisMainElements)
            });
            Index.Add(new WHMISItem
            {
                Id = 4,
                Title = "WHMIS Is The Law!",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageWhmisLaw)
            });
            Index.Add(new WHMISItem
            {
                Id = 5,
                Title = "Responsibilities",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageResponsibilities)
            });
            Index.Add(new WHMISItem
            {
                Id = 6,
                Title = "Class and Category",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageClassAndCategory)
            });
            Index.Add(new WHMISItem
            {
                Id = 7,
                Title = "Hazard Groups & Pictograms",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageHazardGroups)
            });
            Index.Add(new WHMISItem
            {
                Id = 8,
                Title = "Pictograms",
                TargetType = typeof(WHMIS.Views.PocketGuide.PagePictograms)
            });
            Index.Add(new WHMISItem
            {
                Id = 9,
                Title = "Old WHMIS Symbols",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageOldWhmis)
            });
            Index.Add(new WHMISItem
            {
                Id = 10,
                Title = "Labels",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageLabels)
            });
            Index.Add(new WHMISItem
            {
                Id = 11,
                Title = "Supplier Labels",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageSupplierLabels)
            });
            Index.Add(new WHMISItem
            {
                Id = 12,
                Title = "Workplace Labels",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageWorkplaceLabels)
            });
            Index.Add(new WHMISItem
            {
                Id = 13,
                Title = "Safety Data Sheets (SDSs)",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageSDS)
            });
            Index.Add(new WHMISItem
            {
                Id = 14,
                Title = "Trade Secrets",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageTradeSecrets)
            });
            Index.Add(new WHMISItem
            {
                Id = 15,
                Title = "Exemptions",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageExemptions)
            });
            Index.Add(new WHMISItem
            {
                Id = 16,
                Title = "Consumer Based Products",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageConsumerProducts)
            });
            Index.Add(new WHMISItem
            {
                Id = 17,
                Title = "Personal Protective Equipment",
                TargetType = typeof(WHMIS.Views.PocketGuide.PagePPE)
            });
            Index.Add(new WHMISItem
            {
                Id = 18,
                Title = "WHMIS Training",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageWhmisTraining)
            });
            Index.Add(new WHMISItem
            {
                Id = 19,
                Title = "Safe Handeling",
                TargetType = typeof(WHMIS.Views.PocketGuide.PageSafeHandling)
            });
            #endregion


        }
    }
}
