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

namespace WpfApp10リストビュー2
{
    

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public System.Collections.ObjectModel.ObservableCollection<ZipRecord> ZipRecords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            this.ZipRecords = new System.Collections.ObjectModel.ObservableCollection<ZipRecord>();

            listView.DataContext = this.ZipRecords;
        }
        /// <summary>
        /// CSVファイル読み込み
        /// </summary>
        /// <param name="filePath">CSVファイルパス</param>
        private void ReadCsv(string filePath)
        {
            this.ZipRecords.Clear();

            var parser =
                new Microsoft.VisualBasic.FileIO.TextFieldParser(filePath, Encoding.Default);
            using (parser)
            {

                parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                parser.SetDelimiters(",");

                try
                {

                    while (parser.EndOfData == false)
                    {
                        String[] buf = parser.ReadFields();

                        this.ZipRecords.Add(new ZipRecord
                        {
                            Code = buf[0],
                            ZipOld = buf[1],
                            Zip = buf[2],
                            StateKana = buf[3],
                            CityKana = buf[4],
                            TownKana = buf[5],
                            State = buf[6],
                            City = buf[7],
                            Town = buf[8],
                            Flag1 = buf[9],
                            Flag2 = buf[10],
                            Flag3 = buf[11],
                            Flag4 = buf[12],
                            Flag5 = buf[13],
                            Flag6 = buf[14],
                        });
                    }
                }
                catch
                {
                    throw new Exception("CSV読み込みでエラー！");
                }
            }
        }

        private void opneMenu_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.Filter = "CSVファイル(*.csv)|*.csv|テキストファイル(*.txt)|*.txt|全てのファイル(*.*)|*.*";

            dlg.FilterIndex = 1;

            if (dlg.ShowDialog() == true)
            {
                this.IsEnabled = false;

                ReadCsv(dlg.FileName);
                this.IsEnabled = true;
            }
        }

        /// <summary>
        /// メニュー「終了」
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitMenu_Click(object sender, RoutedEventArgs e)
        {
            // プログラム終了
            this.Close();
        }

        /// <summary>
        /// メニュー「クリア」
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearMenu_Click(object sender, RoutedEventArgs e)
        {
            // 一覧をクリア
            this.ZipRecords.Clear();
        }
    }


}
