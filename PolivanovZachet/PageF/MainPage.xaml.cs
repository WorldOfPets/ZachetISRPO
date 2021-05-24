﻿using System;
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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAddSt_Click(object sender, RoutedEventArgs e)
        {
            ClassF.PageClass.frm.Navigate(new AddStudent());
        }

        private void btnAddOcenka_Click(object sender, RoutedEventArgs e)
        {
            ClassF.PageClass.frm.Navigate(new AddOcenka());
        }

        private void btnSee_Click(object sender, RoutedEventArgs e)
        {
            ClassF.PageClass.frm.Navigate(new DataStPage());
        }
    }
}
