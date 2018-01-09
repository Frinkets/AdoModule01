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
// для работы с App.congin/web.config
using System.Configuration;

using System.Data.OleDb;
using System.Data.SqlClient;

namespace AdoNetModule01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string conectonString = "";
        private string conectonStrin_g = "";
        public MainWindow()
        {
            InitializeComponent();
            conectonString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            conectonStrin_g = ConfigurationManager.ConnectionStrings["OleDbConnection"].ConnectionString;
        }

        private void ConnetToServerButton_Click(object sender, RoutedEventArgs e)
        {
            #region exml1
            //SqlConnection connection = new SqlConnection(conectonString);
            //try
            //{
            //    connection.Open();
            //    ConnectionMesseges.Content += "Подключение открыто ...\n";

            //}
            //catch (Exception ex)
            //{
            //    ConnectionMesseges.Content += ex.Message + "\n";
            //}

            //finally
            //{
            //    connection.Close();
            //    ConnectionMesseges.Content += " Подключение закрыто ...\n ";
            //}
            #endregion

            #region exml2
            //using (SqlConnection conn = new SqlConnection(conectonString))
            //{
            //    conn.Open();
            //    ConnectionMesseges.Content += "Подключение открыто";
            //    //получаем информацию о подключении
            //    ConnectionMesseges.Content += "Свойство подключение\n";
            //    ConnectionMesseges.Content += "\t --> строка " + conn.ConnectionString + "\n";
            //    ConnectionMesseges.Content += "\t --> база " + conn.Database + "\n";
            //    ConnectionMesseges.Content += "\t --> сервер " + conn.ServerVersion + "\n";
            //    ConnectionMesseges.Content += "\t --> стостояние " + conn.State + "\n";
            //    ConnectionMesseges.Content += "\t --> рабочая станция " + conn.WorkstationId + "\n";
            //}
            //ConnectionMesseges.Content += " Подключение закрыто ...\n ";
            #endregion

            #region exml3

            //ConnectionMesseges.Content = "";

            //using (OleDbConnection conn = new OleDbConnection(conectonStrin_g))
            //{
            //    conn.Open();
            //    ConnectionMesseges.Content += "Подключение открыто";
            //    //получаем информацию о подключении
            //    ConnectionMesseges.Content += "Свойство подключение\n";
            //    ConnectionMesseges.Content += "\t --> строка " + conn.ConnectionString + "\n";
            //    ConnectionMesseges.Content += "\t --> база " + conn.Database + "\n";
            //    ConnectionMesseges.Content += "\t --> сервер " + conn.ServerVersion + "\n";
            //    ConnectionMesseges.Content += "\t --> стостояние " + conn.State + "\n";


            //}
            //ConnectionMesseges.Content += " Подключение закрыто ...\n ";
            #endregion

        }

        
    }

    public class equiment
    {
        public int EquipmentId { get; set; }
        public string GarageRoom { get; set; }
    }
}
