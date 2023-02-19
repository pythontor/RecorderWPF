using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        string date_global;
        List<jsons> jsons = new List<jsons>();
        jsons json = new jsons();
        public MainWindow()
        {
            InitializeComponent();
        }
 private void Create_b_Click(object sender, RoutedEventArgs e)
        {
            json.rec_name=Rec_name_box.Text;
            json.rec_desc=Rec_desc_box.Text;
            json.rec_date=date_global;
            jsons.Add(json);
            Rec_desc_listbox.ItemsSource = jsons;
            Rec_desc_listbox.DisplayMemberPath = "name";
            Rec_name_box.Text = null;
            Rec_desc_box.Text = null;
            json.Serialize(jsons);
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = Convert.ToDateTime(calendar.Text);
            date_global = date.ToShortDateString();
        }      

        private void Delete_b_Click(object sender, RoutedEventArgs e)
        {
            Rec_desc_listbox.ItemsSource = null;
            Rec_desc_listbox.DisplayMemberPath = null;
            jsons.Clear();
            string json = JsonConvert.SerializeObject(jsons);
            File.WriteAllText("C:\\Users\\миша\\Desktop\\Records.json", json);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
