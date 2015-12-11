using App1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace App1.ViewModels
{
    public class MusicGroupDetailsViewModel : INotifyPropertyChanged
    {
        #region Properties
        private List<Song> songs;

        public List<Song> Songs
        {
            get { return songs; }
            set
            {
                songs = value;
                RaisePropertyChanged("Songs");
            }
        }

        #endregion

        public MusicGroupDetailsViewModel()
        {

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
