using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zad1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.AddLeft.Click += AddLeft_Click;
            this.AddRight.Click += AddRight_Click;
        }

        void AddLeft_Click(object sender, RoutedEventArgs e)
        {
            var rectangle = new Rectangle() 
            {
                Width = 80,
                Height = 80,
                Fill = Brushes.Orange,
                Margin = new Thickness(5)
            };

            this.RectangleContainer1.Children.Add(rectangle);
        }

        void AddRight_Click(object sender, RoutedEventArgs e)
        {
            var rectangle = new Rectangle()
            {
                Width = 350,
                Height = 50,
                Fill = Brushes.Red,
                Margin = new Thickness(5)
            };

            this.RectangleContainer2.Children.Add(rectangle);
        }
    }
}
