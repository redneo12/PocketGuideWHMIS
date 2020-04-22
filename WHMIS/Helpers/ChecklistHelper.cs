using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using WHMIS.Models;

namespace WHMIS.Helpers
{

    public class ChecklistItemHelper
    {
        public static ObservableCollection<Grouping<string, ChecklistItem>> ChecklistItemGrouped { get; set; }

        public static ObservableCollection<ChecklistItem> ChecklistItem { get; set; }

        static ChecklistItemHelper()
        {
            ChecklistItem = new ObservableCollection<ChecklistItem>();


            #region WHMIS
            ChecklistItem.Add(new ChecklistItem
            {

                Item = "The hazardous product has a supplier label.",
                Section = "",
                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "I know where to find the SDS for the product.",
                Section = "",

                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "I recognize and understand the pictograms on the label.",
                Section = "",

                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "I know what precautions to take when working with this product.",
                Section = "",

                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "If the product is moved to a new container or the supplier label is illegible, a workplace label has been placed on the container.",
                Section = "",

                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "I know the safety procedures if there's an emergency involving the hazardous product.",
                Section = "",

                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Supplied the proper WHMIS labels and SDSs.",
                Section = "The Supplier has:",

                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Developed safe work procedures for employees.",
                Section = "The Employer has:",

                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Provided employees with regular WHMIS training.",
                Section = "The Employer has:",

                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Ensured that SDSs are accurate and available.",
                Section = "The Employer has:",

                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Provided workplace labels as required.",
                Section = "The Employer has:",

                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Taken regular WHMIS training.",
                Section = "The Employee has:",

                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Applied their training on a daily basis in the workplace.",
                Section = "The Employee has:",

                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Notified the employer or supplier if labels or SDSs are out of date, inaccurate or missing.",
                Section = "The Employee has:",

                IsChecked = false
            });

            ChecklistItem.Add(new ChecklistItem
            {

                Item = "Used the proper protective equipment while working with each controlled product.",
                Section = "The Employee has:",

                IsChecked = false
            });
            #endregion



            var sorted = from s in ChecklistItem
                         orderby s.ID
                         group s by s.Section into sGroup
                         select new Grouping<string, ChecklistItem>(sGroup.Key, sGroup);


            ChecklistItemGrouped = new ObservableCollection<Grouping<string, ChecklistItem>>(sorted);
        }
    }
}
