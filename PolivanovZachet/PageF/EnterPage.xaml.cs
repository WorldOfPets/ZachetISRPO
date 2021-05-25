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
        static string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1023456789+-.,/?><{}[]()_&#@!$%^*";//Переменная для генирации рандомных символов

        static Random r = new Random();//Рандомайзер
        public EnterPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnHack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbPass.Text = "";//Алгоритм который имметирует подбор пароля
                tbLogin.Text = "";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
            }
            
        }
        static char GetRandomChar()
        {
            try
            {
                var index = r.Next(symbols.Length);//Возвращеает рандомный символ
                return symbols[index];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
                var index = r.Next(symbols.Length);
                return symbols[index];
            }
            
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbLogin.Text != "Admin" || tbPass.Text != "k#o@prjL2O&")//Проверка логина и пароля
                {
                    var result = MessageBox.Show("Взломать систему?", "..::Ошибка входа::..", MessageBoxButton.OK);
                    if (result == MessageBoxResult.OK)
                    {
                        Img.Visibility = Visibility.Visible;//Отображение скрытых элементов
                        btnHack.Visibility = Visibility.Visible;
                    }
                }
                else
                {
                    ClassF.PageClass.frm.Navigate(new MainPage());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
            }
            
        }
    }
}
