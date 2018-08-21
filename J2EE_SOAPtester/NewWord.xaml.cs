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

namespace J2EE_SOAPtester
{
    /// <summary>
    /// Interaction logic for NewWord.xaml
    /// </summary>
    public partial class NewWord : Window
    {
        public string Original { get; set; }
        public string Translated { get; set; }
        public NewWord()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Original = tb_original.Text;
            Translated = tb_translated.Text;
            this.DialogResult = true;
        }
    }
}
