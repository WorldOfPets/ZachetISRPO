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

namespace PolivanovZachet.PageF
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAddSt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClassF.PageClass.frm.Navigate(new AddStudent());//Переход на страницу
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
            }
            
        }

        private void btnAddOcenka_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClassF.PageClass.frm.Navigate(new AddOcenka());//Переход на страницу
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
            }
            
        }

        private void btnSee_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClassF.PageClass.frm.Navigate(new DataStPage());//Переход на страницу
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
            }
            
        }
    }
}
