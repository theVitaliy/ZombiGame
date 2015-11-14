﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MapArea : GameObject, INotifyPropertyChanged
    {

        public AreaType AreaType { get; set; }
        #region Implement INotyfyPropertyChanged members

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
        public MapArea(int x, int y, AreaType type)
        {
            X = x;
            Y = y;
            AreaType = type;
        }
    }
}
