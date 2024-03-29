﻿using System;
using System.Windows;
using System.Windows.Input;

namespace Config_Downloader.View {
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window {
        public LoginScreen() {
            InitializeComponent();
            FocusManager.SetFocusedElement(this, tbxPassword);
        }

        public String GetPassword() {
                this.Close();
                return tbxPassword.Password;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e) {
            DialogResult = true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e) {
            DialogResult = false;
            this.Close();
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {
            DialogResult = false;
            this.Close();
        }
    }
}
