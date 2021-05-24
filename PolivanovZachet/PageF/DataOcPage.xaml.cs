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

            dataOc.ItemsSource = ClassF.DBClass.zachetEntities.Ocenka.Where(x => x.IdStudent == DataStPage.idData).ToList();
        }

        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            ClassF.PageClass.frm.GoBack();
        }
    }
}
