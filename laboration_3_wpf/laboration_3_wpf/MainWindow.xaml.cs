using Microsoft.Win32;
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

namespace laboration_3_wpf
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

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LstUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void Button1_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("The App is closing");
        //    this.Close();
        //}

        //private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog openDlg = new OpenFileDialog();
        //    openDlg.ShowDialog();
        //}

        //private void BtnSaveFile_Click(object sender, RoutedEventArgs e)
        //{
        //    SaveFileDialog SaveDlg = new SaveFileDialog();
        //    SaveDlg.ShowDialog();
        //}

        //private void SendButton_Click(object sender, RoutedEventArgs e)
        //{
        //    usersName = UsersName.Text;
        //    MessageBox.Show($"Hello: {usersName}");
        //}
    }
}
