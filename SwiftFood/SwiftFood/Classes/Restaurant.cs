using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace SwiftFood
{
    public class Restaurant : INotifyPropertyChanged
    {

        //Observable collection of food as the menu
        public ObservableCollection<Food> Menu;


        private string restName;

        public string RestName
        {
            get
            {
                return restName;
            }
            set
            {
                if (restName != value)
                {
                    restName = value;
                    OnPropertyChanged("RestName");
                }
            }
        }

        private int restRating;

        public int RestRating
        {
            get
            {
                return RestRating;
            }
            set
            {
                if (restRating != value)
                {
                    if (value <= 5 && value >= 0)
                    {
                        restRating = value;
                        OnPropertyChanged("RestRating");
                    }
                }
            }
        }

        public string RestImageSource;

        public string RestDescription;

        public string RestAddress;

        public string RestOpeningHours;


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyname)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

    }
}
