using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Settings Flyout item template is documented at http://go.microsoft.com/fwlink/?LinkId=273769

namespace TD_6
{
    public sealed partial class SettingsFlyout1 : SettingsFlyout
    {
        public DateTime UpdatedAt { get; set; }

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


        public SettingsFlyout1()
        {
            this.InitializeComponent();
            sldAmount.Minimum = 0;
            sldAmount.Maximum = 10;
        }
    }
}
