using App1.Models;
using App1.Repositories;
using App1.ViewModels;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MusicGroupDetailsPage : Page
    {
        public MusicGroupDetailsViewModel viewModel = new MusicGroupDetailsViewModel();
        public MusicGroupDetailsPage()
        {
            this.InitializeComponent();
            this.DataContext = viewModel;
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var uniqueId = (int)e.Parameter;
            using (var repository = new MusicRepository())
            {
                viewModel.Songs = repository.MusicGroups.First(m => m.UniqueId.Equals(uniqueId)).Songs.ToList();
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {         
            this.Frame.GoBack();
        }
    }
}
