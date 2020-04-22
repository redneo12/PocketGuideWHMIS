using System;
using Xamarin.Forms;
using WHMIS.Android;
using WHMIS.ViewModels.Base;

[assembly: Dependency(typeof(BaseUrl_Android))]
namespace WHMIS.Android
{
    public class BaseUrl_Android : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/";
        }
    }
}