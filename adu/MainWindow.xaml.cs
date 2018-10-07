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

namespace adu
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

   


        private void Button_Click_OpenNewPage(object sender, RoutedEventArgs e)
        {
            // new Uri("/NewPage.xaml", UriKind.Relative);
            TestMessage.Text = "Open New Page !!!";
        }

        private void Button_Click_Yellow_Tex(object sender, RoutedEventArgs e)
        {
            TestMessage.Text = "yellow !! mega coffee ";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestMessage.Text = "red !!  let's drink";
        }

        private void Button_Click_Blue_Tex(object sender, RoutedEventArgs e)
        {
            TestMessage.Text = "Blue !!  gogogo";
        }
    }
}
