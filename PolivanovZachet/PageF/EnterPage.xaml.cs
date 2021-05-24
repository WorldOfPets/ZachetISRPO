using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для EnterPage.xaml
    /// </summary>
    public partial class EnterPage : Page
    {
        static string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1023456789+-.,/?><{}[]()_&#@!$%^*";

        static Random r = new Random();
        public EnterPage()
        {
            InitializeComponent();
        }

        private async void btnHack_Click(object sender, RoutedEventArgs e)
        {
            tbPass.Text = "";
            string test = "";
            string Login = "Admin";
            string pass = "k#o@prjL2O&";
            for (int i = 0; i <= Login.Length - 1; i++)
            {
                await Task.Delay(100);
                tbLogin.Text += Login[i];
            }
            for (int i = 0; i <= pass.Length - 1; i++)
            {
                await Task.Delay(100);
                tbPass.Text += GetRandomChar();
                await Task.Delay(100);
                tbPass.Text.Remove(tbPass.Text.Length - 1);
                await Task.Delay(100);
                tbPass.Text += GetRandomChar();
                await Task.Delay(100);
                tbPass.Text.Remove(tbPass.Text.Length - 1);
                await Task.Delay(100);
                test += pass[i];
                tbPass.Text = test;
            }
        }
        static char GetRandomChar()
        {
            var index = r.Next(symbols.Length);
            return symbols[index];
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text != "Admin" || tbPass.Text != "k#o@prjL2O&")
            {
                var result = MessageBox.Show("Взломать систему?", "..::Ошибка входа::..", MessageBoxButton.OK);
                if (result == MessageBoxResult.OK)
                {
                    Img.Visibility = Visibility.Visible;
                    btnHack.Visibility = Visibility.Visible;
                }
            }
            else 
            {
                ClassF.PageClass.frm.Navigate(new MainPage());
            }
        }
    }
}
