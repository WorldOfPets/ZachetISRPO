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
    /// Логика взаимодействия для AddOcenka.xaml
    /// </summary>
    public partial class AddOcenka : Page
    {
        public AddOcenka()
        {
            InitializeComponent();

            cmbGroup.SelectedValuePath = "Id";
            cmbGroup.DisplayMemberPath = "Name";
            cmbGroup.ItemsSource = ClassF.DBClass.zachetEntities.Group.ToList();

            cmbDescip.SelectedValuePath = "Id";
            cmbDescip.DisplayMemberPath = "Name";
            cmbDescip.ItemsSource = ClassF.DBClass.zachetEntities.Desciplina.ToList();
        }

        private void btnAddO_Click(object sender, RoutedEventArgs e)
        {
            if (cmbGroup.Text != null  && cmbStudent.Text != null && cmbDescip.Text != null && tbOcenka.Text != null)
            {

                DataBaesF.Ocenka ocenka = new DataBaesF.Ocenka()
                {
                    IdDesciplina = (int)cmbDescip.SelectedValue,
                    IdStudent = (int)cmbStudent.SelectedValue,
                    Ocen = Convert.ToInt32(tbOcenka.Text)
                };
                ClassF.DBClass.zachetEntities.Ocenka.Add(ocenka);
                ClassF.DBClass.zachetEntities.SaveChanges();
                MessageBox.Show("Оценка успешно добавлена");
            }
        }

        private void cmbGroup_DropDownClosed(object sender, EventArgs e)
        {
            cmbStudent.SelectedValuePath = "Id";
            cmbStudent.DisplayMemberPath = "FullName";
            cmbStudent.ItemsSource = ClassF.DBClass.zachetEntities.Student.Where(x => x.IdGroup == (int)cmbGroup.SelectedValue).ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            ClassF.PageClass.frm.GoBack();
        }
    }
}
