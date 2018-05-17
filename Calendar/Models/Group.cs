﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using Windows.UI.Xaml;

namespace Calendar.Models
{
    public class Group : INotifyPropertyChanged
    {
        public ObservableCollection<TodoItem> itemList = new ObservableCollection<TodoItem>();
        public string listName;
        private Visibility vis;
        public Visibility Vis
        {
            set
            {
                vis = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Vis"));
                    PropertyChanged(this, new PropertyChangedEventArgs("openFlag"));
                }
            }
            get
            {
                return vis;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public Group(ObservableCollection<TodoItem> todoItems)
        {
            itemList = todoItems;
            listName = "defaultListName";
        }

        public string openFlag
        {
            set
            {

            }

            get
            {
                if (Vis == Visibility.Visible)
                {
                    return "-";
                }
                else
                {
                    return "+";
                }
            }
        }

    }
}
