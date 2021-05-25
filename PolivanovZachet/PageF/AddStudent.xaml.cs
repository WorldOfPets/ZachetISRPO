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

            try
            {
                //Загрузка данных из БД в комбобокс
                cmbSpec.SelectedValuePath = "Id";
                cmbSpec.DisplayMemberPath = "Name";
                cmbSpec.ItemsSource = ClassF.DBClass.zachetEntities.Spec.ToList();
                //Загрузка данных из БД в комбобокс
                cmbGroup.SelectedValuePath = "Id";
                cmbGroup.DisplayMemberPath = "Name";
                cmbGroup.ItemsSource = ClassF.DBClass.zachetEntities.Group.ToList();
                //Добавление данных в комбобокс
                cmbFormOb.Items.Add("Очная");
                cmbFormOb.Items.Add("Заочная");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
            }
            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbFio.Text != "" && DataPicker.SelectedDate != null && cmbSpec.Text != "" && cmbGroup.Text != "" && cmbFormOb.Text != "")//Проверка на нулевые значения текстбоксов
                {

                    DataBaesF.Student student = new DataBaesF.Student()//Создание экземпляра таблицы БД для добовления данных
                    {
                        FullName = tbFio.Text,//Добавление данных
                        DatePost = DataPicker.SelectedDate,
                        IdSpec = (int)cmbSpec.SelectedValue,
                        IdGroup = (int)cmbGroup.SelectedValue,
                        FormaOb = cmbFormOb.Text
                    };
                    ClassF.DBClass.zachetEntities.Student.Add(student);//Добавление данных в БД
                    ClassF.DBClass.zachetEntities.SaveChanges();//Сохранение данных в БД
                    MessageBox.Show("Студент успешно добавлен");
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
