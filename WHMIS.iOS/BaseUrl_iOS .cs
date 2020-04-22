﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WHMIS.iOS;
using Foundation;
using WHMIS.ViewModels.Base;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl_iOS))]
namespace WHMIS.iOS
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}