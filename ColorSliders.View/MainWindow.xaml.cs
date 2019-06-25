using ColorSliders.ViewModel;
using System;
using System.Windows;
using System.Windows.Input;

namespace ColorSliders.View
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RectangleColor rectangleColor = new RectangleColor();
        public MainWindow()
        {
            InitializeComponent();
            MainStackPanel.DataContext = rectangleColor;
        }


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape) Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            rectangleColor.SaveCurrentColor();
        }
    }
}
