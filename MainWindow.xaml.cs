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
using Microsoft.Win32;
using System.Windows.Forms;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         


        }

        private void btn01_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Title = "选择数据源文件";
            openFileDialog.Filter = "txt文件|*.txt";
            openFileDialog.FileName = string.Empty;
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.DefaultExt = "txt";
            if (openFileDialog.ShowDialog() == false)
            {
                return;
            }

            txtfile01.Text = openFileDialog.FileName;

           
         
        }

        private void btn02_Click(object sender, RoutedEventArgs e)
        {

            var m_Dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = m_Dialog.ShowDialog();
             
            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            txtfile02.Text = m_Dialog.SelectedPath.Trim();
        }

        private void btn03_Click(object sender, RoutedEventArgs e)
        {
            var m_Dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = m_Dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            txtfile03.Text = m_Dialog.SelectedPath.Trim();
        }
    }
}
