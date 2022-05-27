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

namespace WpfApp4画面遷移
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

        private void dialogButton_Click(object sender, RoutedEventArgs e)
        {
            // ウィンドウ生成
            var window = new DialogWindow1();

            // 生成したウィンドウのテキストに文字列設定
            window.clickButtonText.Text = (sender as Button).Content + "が押されました。";
            // ウィンドウ表示
            bool? res = window.ShowDialog();

            // DialogResultをチェック
            if (res == true)
            {
                textBlock.Text = "OKでダイアログが終了。";
            }
            else
            {
                textBlock.Text = "キャンセルでダイアログが終了。";
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // ウィンドウ生成
            var window = new Window1();
            // ウィンドウ表示
            window.Show();
            // MainWindowを隠す
            this.Hide();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            // ウィンドウ生成
            var window = new Window2();
            // ウィンドウ表示
            window.Show();

        }
    }
}
