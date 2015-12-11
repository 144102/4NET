using App1.Models;
using App1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Properties
        private List<MusicGroup> musicGroups;

        public List<MusicGroup> MusicGroups
        {
            get { return musicGroups; }
            set
            {
                musicGroups = value;
                RaisePropertyChanged("MusicGroups");
            }
        }
        #endregion

        public MainViewModel()
        {
            using (var repository = new MusicRepository())
            {
                MusicGroups = repository.MusicGroups;
            }            
        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

    }
}
