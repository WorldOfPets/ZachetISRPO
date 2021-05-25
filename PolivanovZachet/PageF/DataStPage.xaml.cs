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
    /// Логика взаимодействия для DataStPage.xaml
    /// </summary>
    public partial class DataStPage : Page
    {
        public static int idData { get; set; }
        public DataStPage()
        {
            InitializeComponent();
            try
            {
                //Загрузка данных в датагрид из БД
                dataSt.ItemsSource = ClassF.DBClass.zachetEntities.Student.ToList();
                //Загрузка данных из БД в комбобокс
                cmbSort.SelectedValuePath = "Id";
                cmbSort.DisplayMemberPath = "Name";
                cmbSort.ItemsSource = ClassF.DBClass.zachetEntities.Group.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
            }
            
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)//Переход на страницу оценок по двойному клику
        {
            try
            {
                var row = (DataGridRow)sender;
                var context = row.DataContext as DataBaesF.Student;
                if (context == null) return;
                idData = context.Id;

                ClassF.PageClass.frm.Navigate(new DataOcPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSort_Click(object sender, RoutedEventArgs e)//Сортировака данных в дата грид
        {
            try
            {
                if (cmbSort.Text != null)
                {
                    dataSt.ItemsSource = ClassF.DBClass.zachetEntities.Student.Where(x => x.IdGroup == (int)cmbSort.SelectedValue).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
            }
            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
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
