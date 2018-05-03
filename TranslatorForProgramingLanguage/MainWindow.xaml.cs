using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace TranslatorForProgramingLanguage
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
        private void Start_Click(object sender, RoutedEventArgs e)
        {
        }


        List<string> GetListStringFromRichTextBox(RichTextBox rtb)
        {
            var document = rtb.Document;
            List<string> listString = new List<string>();

            foreach (var item in document.Blocks)
            {

                string temp = new TextRange(item.ContentStart, item.ContentEnd).Text;
                temp = ClearingRowOfCode(temp);

                if (temp != null) listString.Add(temp);
            }

            return listString;
        }

        private string ClearingRowOfCode(string text)
        {
            if (text == "" || text == "\t\t" || text.StartsWith("//"))
                return null;
            else
            {
                text = text.Replace('\t', ' ');
                //text.Remove(text.IndexOf("//")); todo:add comments
                //todo:  delet spaces in the end of row
            }
            return text;
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {

            TextRange range;
            range = new TextRange(codeTextBox.Document.ContentStart, codeTextBox.Document.ContentEnd);

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                range.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void SaveAs_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
