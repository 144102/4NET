using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TD_6.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TD_6
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class MainPage : Page
    {

        private PersonViewModel mainViewModel = new PersonViewModel();

        public PersonViewModel MainViewModel
        {
            get { return mainViewModel; }
            set { mainViewModel = value; }
        }

        public MainPage()
        {
            this.InitializeComponent();
            base.DataContext = mainViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Name += "1";
            MainViewModel.Persons.Add(new Models.Person { FirstName="addedFN", LastName="addedLN"});
        }
    }
}
