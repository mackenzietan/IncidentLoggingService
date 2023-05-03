using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; 

using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IncidentLoggingService
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

        static void DbConnect()
        {
            string connectionString;
            connectionString = @"Data Source=ISAL05;Initial Catalog=ILS;User ID=sa;Password=Dev3560?";

            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Open();
        }

        static void DbDisconnect()
        {
            string connectionString;
            connectionString = @"Data Source=ISAL05;Initial Catalog=ILS;User ID=sa;Password=Dev3560?";

            SqlConnection cnn = new SqlConnection(connectionString);

            cnn.Close();
        }

        private void commitLog_Click(object sender, RoutedEventArgs e)
        {
            //here we want to call another method that adds the entered values in the db
            //process: open, add, close
        }


    }
}
