using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using phoneword.iOS;
using MonoTouch.UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneDialer))]
namespace phoneword.iOS
{
    class PhoneDialer :IDialer
    {
        public bool Dial(string number)
        {
            return UIApplication.ShareApplication.OpenUrl(
                new NSUrl("tel: " + number));
        }

    }
}