using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Settings Flyout item template is documented at http://go.microsoft.com/fwlink/?LinkId=273769

namespace HubApp2
{
    public sealed partial class SettingsFlyout1 : SettingsFlyout
    {
        #region Properties
        private DateTime lastUpdatedAt = DateTime.MinValue;
        public DateTime LastUpdatedAt
        {
            get
            {
                return lastUpdatedAt;
            }
            set { lastUpdatedAt = value; }
        }
        
        public string TxtboxName
        {
            get
            {
                return txtboxName.Text;
            }
        }

        public double SldAmount
        {
            get
            {
                return sldAmount.Value;
            }
        }

        public bool TglRefill
        {
            get
            {
                return tglRefill.IsOn;
            }
        }

        #endregion
        public SettingsFlyout1()
        {
            this.InitializeComponent();
            sldAmount.Minimum = 0;
            sldAmount.Maximum = 10;

            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            var name = localSettings.Values["Name"];
            var amount = localSettings.Values["Amount"];
            var refill = localSettings.Values["Refill"];
            var lastUpdatedAt = localSettings.Values["LastUpdatedAt"];

            txtboxName.Text = name !=null ? (String)name :String.Empty  ;
            sldAmount.Value = amount !=null? (double)amount : 0;
            tglRefill.IsOn = refill !=null ?(bool)refill : false;
            if(lastUpdatedAt != null)
            {
                txtbckLastUpdatedAt.Text =  DateTime.Parse((string)lastUpdatedAt).ToString();
                txtbckLastUpdatedAt.Visibility = Visibility.Visible;
            }
            else
            {
                txtbckLastUpdatedAt.Visibility = Visibility.Collapsed;
            }
            
        }
    }
}
