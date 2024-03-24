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
using System.Data.SqlClient;
using System.Runtime.Remoting.Channels;
using System.Data;

namespace _2
{
    enum Rowstate{
            Existed_

    
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB DB = new DB(); 
        public MainWindow()
        {
            InitializeComponent();
        }


        private void tabla_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string zap = ("select * from Product");
            SqlCommand command = new SqlCommand(zap, DB.GetConnection());
            tabla.Columns.Add("id", "код товара");

                
        }
    }
}
