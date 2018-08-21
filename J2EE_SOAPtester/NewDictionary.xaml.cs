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
    /// Interaction logic for NewDictionary.xaml
    /// </summary>
    public partial class NewDictionary : Window
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public NewDictionary()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Name = tb_name.Text;
            Type = tb_name.Text;
            this.DialogResult = true;
        }
    }
}
