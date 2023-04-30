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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int score_num = 0;

        private string HaveText(string path)
        {
            string txt = "";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] array = new byte[fs.Length];
                fs.Read(array, 0, array.Length);
                txt = System.Text.Encoding.Default.GetString(array);
            }

            return txt;


       




        }
        private void MakeText(string path, string txt)
        {
            

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(txt);

                fs.Write(array, 0, array.Length);


            }

        }

        private void CleanFile(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                // Записываем пустую строку в файл
                writer.Write("");
            }
        }
        private void DeleteRecords(string path)
        {

            CleanFile(path);
            string test = "";
            string txt = "1.Chupapi Munyanya: 2421\r\n2.Muhamed Abdul: 2341\r\n3.Amogus: 1234\r\n\r\n< Worthy to mark> :";
            MakeText(path, txt);
        }

        public MainWindow()
        {
            InitializeComponent();
            textBox.Content = "Score: " + score_num;
            InitializeComponent();
            Rectangle rectangle = new();
            records.Visibility = Visibility.Hidden;
            RecordTxtLabel.Visibility = Visibility.Hidden; 
            CrossButton.Visibility = Visibility.Hidden;
            
            UpdateRecordsButton.Visibility = Visibility.Hidden;
            Choose_Mod_Grid.Visibility = Visibility.Hidden;
            Far_Mode_Grid.Visibility = Visibility.Hidden;


        }
        


            private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            score_num += 1;
            textBox.Content = "Score: " + score_num;
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            records.Content = HaveText("C:\\Users\\TUF Gaming\\Desktop\\Stuff\\WpfApp1\\WpfApp1\\Records.txt");
            records.Visibility = Visibility.Visible;
            RecordTxtLabel.Visibility = Visibility.Visible;
            CrossButton.Visibility = Visibility.Visible;
            
            UpdateRecordsButton.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            records.Visibility = Visibility.Hidden;
            RecordTxtLabel.Visibility = Visibility.Hidden;
            CrossButton.Visibility = Visibility.Hidden;
            
            UpdateRecordsButton.Visibility = Visibility.Hidden;
        }

        

        private void UpdateRecordsButton_Click(object sender, RoutedEventArgs e)
        {
            records.Content = HaveText("C:\\Users\\TUF Gaming\\Desktop\\Stuff\\WpfApp1\\WpfApp1\\Records.txt");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainMenuGrid.Visibility = Visibility.Hidden;
            Choose_Mod_Grid.Visibility = Visibility.Visible;
            
            string you = NicknameTextBox.Text;
        }
        

        private void EraseRecordButton_Click(object sender, RoutedEventArgs e)
        {
            

            DeleteRecords("C:\\Users\\TUF Gaming\\Desktop\\Stuff\\WpfApp1\\WpfApp1\\Records.txt");
        }
        private void AddRecordButton_Click(object sender, RoutedEventArgs e)
        {
            string txt = HaveText("C:\\Users\\TUF Gaming\\Desktop\\Stuff\\WpfApp1\\WpfApp1\\Records.txt");

            txt += "\r\n" + NicknameTextBox.Text + ": " + score_num;
            MakeText("C:\\Users\\TUF Gaming\\Desktop\\Stuff\\WpfApp1\\WpfApp1\\Records.txt", txt);
        }

        private void Minecraft_Mod_Button_Click(object sender, RoutedEventArgs e)
        {
            Choose_Mod_Grid.Visibility = Visibility.Hidden;

        }

        private void Fart_Mod_Button_Click(object sender, RoutedEventArgs e)
        {
            Choose_Mod_Grid.Visibility = Visibility.Hidden;
            Far_Mode_Grid.Visibility = Visibility.Visible;
            RecsRecs.Visibility = Visibility.Hidden;
            MemeButton.Visibility = Visibility.Hidden;
        }

        private void Do_Fart_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:\\Users\\TUF Gaming\\Desktop\\Stuff\\WpfApp1\\WpfApp1\\fart-1.wav");
            player.Play();
            score_num += 1;
            textBox1.Content = "       Farts: " + score_num;
            Random rnd = new Random();
            MemeButton.Visibility = Visibility.Visible;
            //MemeButton.Location = new Point(100, 100);
            //MemeButton. (rnd.Next(0, 450), rnd.Next(0, 850));
        }

        private void AddRecord_Click(object sender, RoutedEventArgs e)
        {
            string txt = HaveText("C:\\Users\\TUF Gaming\\Desktop\\Stuff\\WpfApp1\\WpfApp1\\Records.txt");

            txt += "\r\n" + NicknameTextBox.Text + ": " + score_num;
            MakeText("C:\\Users\\TUF Gaming\\Desktop\\Stuff\\WpfApp1\\WpfApp1\\Records.txt", txt);
            
        }

        private void UpdateRecord_Click(object sender, RoutedEventArgs e)
        {
            Your_Recs.Content = HaveText("C:\\Users\\TUF Gaming\\Desktop\\Stuff\\WpfApp1\\WpfApp1\\Records.txt");
        }


   

        private void Recs1_Click_1(object sender, RoutedEventArgs e)
        {
            Recs1.Visibility = Visibility.Hidden;
            RecsRecs.Visibility = Visibility.Visible;
            Your_Recs.Content = HaveText("C:\\Users\\TUF Gaming\\Desktop\\Stuff\\WpfApp1\\WpfApp1\\Records.txt");
        }

        private void CloseReords_Click(object sender, RoutedEventArgs e)
        {
            RecsRecs.Visibility = Visibility.Hidden;
            Recs1.Visibility = Visibility.Visible;
        }
    }

}
//Добавить возможность записи имени в рекорды