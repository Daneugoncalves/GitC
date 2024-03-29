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

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }
        public event EventHandler loginCorrect;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Teste(tbxLogin.Text, tbxSenha.Text);
        }

        public void Teste(string login, string senha)
        {
            if (login == "admin" && senha == "admin")
            {
                this.Visibility = Visibility.Hidden;
                Calculadora novoformX = new Calculadora();

                novoformX.Show();
            }
            else
                MessageBox.Show("Login Inválido");
        }
    }
}
