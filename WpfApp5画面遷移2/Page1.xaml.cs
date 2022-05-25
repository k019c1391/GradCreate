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
    /// Page1.xaml の相互作用ロジック
    /// </summary>
    public partial class Page1 : Page
    {

        private static Page2 page2 = null;

        // コンストラクタ
        public Page1()
        {
            InitializeComponent();
        }

        // 「次へ」ボタンの処理
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (page2 == null)
            { 
                // 次に表示するページを生成
                page2 = new Page2();   
            }

            // ページ2へ移動
            this.NavigationService.Navigate(page2);
        }
    }
}
