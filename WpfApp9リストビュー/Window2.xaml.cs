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
using System.Windows.Shapes;

namespace WpfApp9リストビュー
{
    /// <summary>
    /// Window2.xaml の相互作用ロジック
    /// </summary>
    public partial class Window2 : Window
    {
        ObservableCollection<Person> Persons { get; set; }

        public Window2()
        {
            InitializeComponent();

            this.Persons = new ObservableCollection<Person>();
            listView.DataContext = this.Persons;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            int i = new Random().Next(100, 1000);

            this.Persons.Add(new Person { ID = i, Name = $"ユーザー{i}" });
        }
    }
}
