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

            try
            {
                //Загрузка данных из БД в комбобокс
                cmbGroup.SelectedValuePath = "Id";
                cmbGroup.DisplayMemberPath = "Name";
                cmbGroup.ItemsSource = ClassF.DBClass.zachetEntities.Group.ToList();
                //Загрузка данных из БД в комбобокс
                cmbDescip.SelectedValuePath = "Id";
                cmbDescip.DisplayMemberPath = "Name";
                cmbDescip.ItemsSource = ClassF.DBClass.zachetEntities.Desciplina.ToList();
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
        private void btnAddO_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cmbGroup.Text != "" && cmbStudent.Text != "" && cmbDescip.Text != "" && tbOcenka.Text != "")//Проверка на нулевые значения текстбоксов
                {
                    if (Convert.ToInt32(tbOcenka.Text) <= 5 && Convert.ToInt32(tbOcenka.Text) >= 2) 
                    {
                        DataBaesF.Ocenka ocenka = new DataBaesF.Ocenka()//Создание экземпляра таблицы БД для добовления данных
                        {
                            IdDesciplina = (int)cmbDescip.SelectedValue,//Добавление данных
                            IdStudent = (int)cmbStudent.SelectedValue,
                            Ocen = Convert.ToInt32(tbOcenka.Text)
                        };
                        ClassF.DBClass.zachetEntities.Ocenka.Add(ocenka);//Добавление данных в БД
                        ClassF.DBClass.zachetEntities.SaveChanges();//Сохранение данных в БД
                        MessageBox.Show("Оценка успешно добавлена");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "..::Error::..");
            }
            
        }

        private void cmbGroup_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                //Загрузка данных из БД в комбобокс при выборе группы
                cmbStudent.SelectedValuePath = "Id";
                cmbStudent.DisplayMemberPath = "FullName";
                cmbStudent.ItemsSource = ClassF.DBClass.zachetEntities.Student.Where(x => x.IdGroup == (int)cmbGroup.SelectedValue).ToList();
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
