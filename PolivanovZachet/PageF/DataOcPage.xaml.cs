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
    /// Логика взаимодействия для DataOcPage.xaml
    /// </summary>
    public partial class DataOcPage : Page
    {
        public DataOcPage()
        {
            InitializeComponent();

            try
            {
                dataOc.ItemsSource = ClassF.DBClass.zachetEntities.Ocenka.Where(x => x.IdStudent == DataStPage.idData).ToList();//Загрузка данных в дата грид из БД
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
            }
            
        }

        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClassF.PageClass.frm.GoBack();//Переход назад
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
            }
            
        }
    }
}
