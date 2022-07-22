using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<people> peolist = new ObservableCollection<people>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("点我");
           
        }

        private void LoadData(object sender, RoutedEventArgs e)
        {
            peolist.Add(new people()
            {
                id = "01",
                name = "张三",
            });
            peolist.Add(new people()
            {
                id = "02",
                name = "李三",
            });
            Data_Grid.ItemsSource = peolist;
        }

        public class people
        {
            public string id { get; set; }
            public string name { get; set; }
        }
    }
}
