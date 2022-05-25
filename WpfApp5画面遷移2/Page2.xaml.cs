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
    /// Page2.xaml の相互作用ロジック
    /// </summary>
    public partial class Page2 : Page
    {
        private static Page3 page3 = null;

        // コンストラクタ
        public Page2()
        {
            InitializeComponent();
        }

        // 「次へ」ボタンの処理
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (page3 == null)
            {
                // 次に表示するページを生成
                page3 = new Page3();
            }

            // ページ3へ移動
            this.NavigationService.Navigate(page3);
        }
    }
}
