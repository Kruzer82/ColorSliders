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
            ColorSliderWindow.DataContext = rectangleColor;
        }

        private void ColorSliderWindow_Closed(object sender, EventArgs e)
        {
            rectangleColor.SaveCurrentColor();
        }
    }
}
