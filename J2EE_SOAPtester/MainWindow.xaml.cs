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
using J2EE_SOAPtester.WordSoap;

namespace J2EE_SOAPtester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WordClient wc;
        long actualdict;
        public MainWindow()
        {
            InitializeComponent();
            wc = new WordClient();
            lb_dicts.ItemsSource = wc.GetDictionaries();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dictionaryStub ds = lb_dicts.SelectedItem as dictionaryStub;
            if (ds != null)
            {
                wc.DeleteDictionary(ds.id.ToString());
                lb_dicts.ItemsSource = wc.GetDictionaries();
            }
        }

        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NewDictionary nd = new NewDictionary();
            if (nd.ShowDialog() == true)
            {
                wc.NewDictionary(nd.Name, nd.Type);
            }
            lb_dicts.ItemsSource = wc.GetDictionaries();
        }

        private void lb_dicts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dictionaryStub ds = lb_dicts.SelectedItem as dictionaryStub;
            if (ds != null)
            {
                translationStub[] trans = wc.GetTranslationsForDictionary(ds.id);
                translationStub tt = new translationStub();
                lb_words.ItemsSource = trans;
                actualdict = ds.id; ;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewWord nw = new NewWord();
            if (nw.ShowDialog() == true)
            {
                wc.NewTranslation(actualdict, nw.Original, nw.Translated);
                translationStub[] trans = wc.GetTranslationsForDictionary(actualdict);
                lb_words.ItemsSource = trans;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var trans = lb_words.SelectedItem as translationStub;
            if (trans != null)
            {
                wc.DeleteTranslation(trans.id);
                translationStub[] transs = wc.GetTranslationsForDictionary(actualdict);
                lb_words.ItemsSource = transs;
            }
        }
    }
}
