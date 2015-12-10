using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using TD_6.Models;

namespace TD_6.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        #region Properties
        private string name = "MyName";
        public string Name
        {
            get{ return name; }
            set
            {
                name = value;
                RaisePropertyChanged("Name");
            }
        }

        private ObservableCollection<Person> persons = new ObservableCollection<Person>();

        public ObservableCollection<Person> Persons
        {
            get { return persons; }
            set
            {
                persons = value;
                RaisePropertyChanged("Persons");
            }
        }



        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public PersonViewModel()
        {
            this.persons.Add(new Person()
            {
                FirstName = "John",
                LastName = "Doe"
            });
            this.persons.Add(new Person()
            {
                FirstName = "Jack",
                LastName = "Harkness"
            });
        }

        

        private void RaisePropertyChanged(string propertyName)
        {

            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }

        }

    }
}
