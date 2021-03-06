﻿using System;
using System.Windows;

namespace TraceSpy
{
    public partial class EtwProviderWindow : Window
    {
        public EtwProviderWindow(EtwProvider provider)
        {
            if (provider == null)
                throw new ArgumentNullException(nameof(provider));

            InitializeComponent();
            Provider = provider;
            DataContext = provider;
        }

        public EtwProvider Provider { get; }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
