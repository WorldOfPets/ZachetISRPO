using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Page
    {
        public AddStudent()
        {
            InitializeComponent();

            cmbSpec.SelectedValuePath = "Id";
            cmbSpec.DisplayMemberPath = "Name";
            cmbSpec.ItemsSource = ClassF.DBClass.zachetEntities.Spec.ToList();

            cmbGroup.SelectedValuePath = "Id";
            cmbGroup.DisplayMemberPath = "Name";
            cmbGroup.ItemsSource = ClassF.DBClass.zachetEntities.Group.ToList();

            cmbFormOb.Items.Add("Очная");
            cmbFormOb.Items.Add("Заочная");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (tbFio.Text != null && DataPicker.SelectedDate != null && cmbSpec.Text != null && cmbGroup.Text != null && cmbFormOb.Text != null)
            {

                DataBaesF.Student student = new DataBaesF.Student()
                {
                    FullName = tbFio.Text,
                    DatePost = DataPicker.SelectedDate,
                    IdSpec = (int)cmbSpec.SelectedValue,
                    IdGroup = (int)cmbGroup.SelectedValue,
                    FormaOb = cmbFormOb.Text
                };
                ClassF.DBClass.zachetEntities.Student.Add(student);
                ClassF.DBClass.zachetEntities.SaveChanges();
                MessageBox.Show("Студент успешно добавлен");
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            ClassF.PageClass.frm.GoBack();
        }
    }
}
