using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClassLibrary1;
using System.IO;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MUDA s = new MUDA(TBB.Text, TBA.Text);
            lbl.Content = "Summ" + s.sum();
            StreamWriter SaveRes = new StreamWriter(@"D:\Programms\WpfApp4\RES.txt", true);
            SaveRes.WriteLine(s.sum());
            SaveRes.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow menu = new MainWindow();
            menu.Show();
            Close();
        }
    }
}
