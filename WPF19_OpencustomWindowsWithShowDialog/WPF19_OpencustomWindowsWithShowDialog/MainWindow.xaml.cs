﻿using System.Windows;
using WPF19_OpencustomWindowsWithShowDialog.View;

namespace WPF19_OpencustomWindowsWithShowDialog
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            NormalWindow normalWindow = new NormalWindow();
            normalWindow.Show();

        }

        private void btnModal_Click(object sender, RoutedEventArgs e)
        {
            ModalWindow modalWindow = new ModalWindow();
            modalWindow.ShowDialog();

            if (modalWindow.Success)
            {
                txtInput.Text = modalWindow.Input;
            }

        }
    }
}