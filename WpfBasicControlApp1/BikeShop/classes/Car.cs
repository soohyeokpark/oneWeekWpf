using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace BikeShop.classes
{
    class Car : INotifyPropertyChanged
    {
        private double Speed;
        
        public Color Color { get; set; }
        public Human Driver { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public double speed
        {
            get
            {
                return this.Speed;
            }
            set
            {
                Speed = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Speed"));
            }
        }
    }

    public class Human
    {

    }
}
