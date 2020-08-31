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

namespace WpfTicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DisableButtons();
        }

        private void DisableButtons()
        {
            btn1_1.IsEnabled = false;
            btn1_2.IsEnabled = false;
            btn1_3.IsEnabled = false;
            btn2_1.IsEnabled = false;
            btn2_2.IsEnabled = false;
            btn2_3.IsEnabled = false;
            btn3_1.IsEnabled = false;
            btn3_2.IsEnabled = false;
            btn3_3.IsEnabled = false;
        }

        private void Button_Click_Play(object sender, RoutedEventArgs e)
        {
            if (x.IsChecked == true)
            {

            }
        }
    }
}
