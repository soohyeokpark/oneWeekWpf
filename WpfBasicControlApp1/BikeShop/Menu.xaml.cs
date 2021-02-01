using System;
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

namespace BikeShop
{
    /// <summary>
    /// Menu.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
            MakeDataContext(); // test
        }

        private void MakeDataContext()
        {
            var cars = new List<classes.Car>();
            for(int i= 0; i< 10; i++)
            {
                cars.Add(new classes.Car() {
                    Speed = i * 10
                });
            }
            this.DataContext = cars;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            string now_button_content = (sender as Button).Content.ToString();
            string uri = string.Empty;

            if(now_button_content == "Products")
            {
                uri = "";
            } 
            else if (now_button_content == "Live support")
            {
                uri = "/Discussion.xaml";
            } 
            else if (now_button_content == "Email support")
            {
                uri = "/Contact.xaml";
            }

            NavigationService.Navigate(new Uri(uri, UriKind.Relative));
        }


    }
}
