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

namespace WpfApp5画面遷移2
{
    /// <summary>
    /// Page3.xaml の相互作用ロジック
    /// </summary>
    public partial class Page3 : Page
    {
        // コンストラクタ
        public Page3()
        {
            InitializeComponent();
        }

        //「完了」ボタンの処理
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // メイン画面を閉じる
            App.Current.MainWindow.Close();

        }

        

    }
}
