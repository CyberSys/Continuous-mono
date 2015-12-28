﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace Continuous.Client.VisualStudio
{
    public partial class MainPadControl : UserControl
    {
        public MainPadControl()
        {
            this.InitializeComponent();
        }

        void HandleSetType (object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "Continuous Coding");
        }
        void HandleRefresh(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "Continuous Coding");
        }
        void HandleClearEdits(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "Continuous Coding");
        }
        void HandleStop(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "Continuous Coding");
        }
    }
}