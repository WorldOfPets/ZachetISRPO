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
                dataSt.ItemsSource = ClassF.DBClass.zachetEntities.Student.ToList();

                cmbSort.SelectedValuePath = "Id";
                cmbSort.DisplayMemberPath = "Name";
                cmbSort.ItemsSource = ClassF.DBClass.zachetEntities.Group.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
            }
            
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
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

        private void btnSort_Click(object sender, RoutedEventArgs e)
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
                ClassF.PageClass.frm.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
            }
            
        }
    }
}
