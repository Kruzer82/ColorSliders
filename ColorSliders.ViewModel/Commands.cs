using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ColorSliders.ViewModel
{
    class Commands:ICommand
    {
        private RectangleColor rectangleColor;
        public Commands(RectangleColor rectangleColor)
        {
            if (rectangleColor == null) throw new ArgumentNullException("rectangleColor");
            this.rectangleColor = rectangleColor;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return (rectangleColor.RedSlider != 0) || (rectangleColor.GreenSlider != 0) || (rectangleColor.BlueSlider != 0);
        }

        public void Execute(object parameter)
        {
            //EdycjaKoloru modelWidoku = parameter as EdycjaKoloru;
            rectangleColor.RedSlider = 0;
            rectangleColor.GreenSlider = 0;
            rectangleColor.BlueSlider = 0;
        }
    }
}
