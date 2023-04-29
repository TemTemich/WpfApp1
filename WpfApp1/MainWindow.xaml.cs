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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int score_num = 0;
        public MainWindow()
        {
            InitializeComponent();
            textBox.Content = "Score: " + score_num;
            
        }
        


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            score_num += 1;
            textBox.Content = "Score: " + score_num;
        }
    }
}
