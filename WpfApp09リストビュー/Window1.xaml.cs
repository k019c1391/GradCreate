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
using System.Windows.Shapes;

namespace WpfApp9リストビュー
{
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window
    {
        List<Person> Persons { get; set; }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Window1()
        {
            InitializeComponent();

            this.Persons = new List<Person>();
            this.Persons.Add(new Person { ID = 33, Name = "さぶろー" });
            this.Persons.Add(new Person { ID = 44, Name = "しろー" });
            listView.DataContext = this.Persons;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            new Window2().Show();
        }
    }
}
