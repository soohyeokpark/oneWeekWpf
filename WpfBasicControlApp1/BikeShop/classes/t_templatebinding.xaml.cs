﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BikeShop.classes
{
    /// <summary>
    /// t_templatebinding.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class t_templatebinding : Page
    {
        public t_templatebinding()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HI");
        }
    }
}
