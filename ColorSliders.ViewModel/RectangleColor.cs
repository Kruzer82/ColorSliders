using ColorSliders.Model;
using System.ComponentModel;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows;

namespace ColorSliders.ViewModel
{
    public class RectangleColor : INotifyPropertyChanged
    {
        private RGB rectangleRGB = LastColorDAL.ReadLastRGB();

        public Color FullColor { get { return RgbAsColor(); } }

        public byte RedSlider
        {
            get
            {
                return rectangleRGB.Red;
            }
            set
            {
                rectangleRGB.Red = value;
                RaiseMultiPropertyChanged("RedSlider", "FullColor");
            }
        }

        public byte GreenSlider
        {
            get
            {
                return rectangleRGB.Green;
            }
            set
            {
                rectangleRGB.Green = value;
                RaiseMultiPropertyChanged("GreenSlider", "FullColor");
            }
        }

        public byte BlueSlider
        {
            get
            {
                return rectangleRGB.Blue;
            }
            set
            {
                rectangleRGB.Blue = value;
                RaiseMultiPropertyChanged("BlueSlider", "FullColor");
            }
        }


        private Color RgbAsColor()
        {
            return new Color()
            {
                A = 255,
                R = rectangleRGB.Red,
                G = rectangleRGB.Green,
                B = rectangleRGB.Blue
                //R = 50,
                //G = 190,
                //B = 10
            };
        }

        public void SaveCurrentColor()
        {
            LastColorDAL.WriteLastRGB(new RGB(RedSlider, GreenSlider, BlueSlider));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaiseMultiPropertyChanged(params string[] nazwyWłasności)
        {
            if (PropertyChanged != null)
            {
                foreach (string nazwaWłasności in nazwyWłasności)
                    PropertyChanged(this, new PropertyChangedEventArgs(nazwaWłasności));
            }
        }

        #region Commands

        private ICommand resetSlidersCommand;

        public ICommand Reset
        {
            get
            {
                if (resetSlidersCommand == null)
                {
                    resetSlidersCommand = new RelayCommand(
                        argument =>
                        {
                            RedSlider = 0;
                            GreenSlider = 0;
                            BlueSlider = 0;
                        },
                        argument => (RedSlider != 0) || (GreenSlider != 0) || (BlueSlider != 0)
                    );
                }
                return resetSlidersCommand;
            }
        }

        public ICommand CloseWindow
        {
            get
            {
                return new RelayCommand(argument => { (argument as Window).Close();  });
            }
        }
        #endregion

    }
}
