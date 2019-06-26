using ColorSliders.Model;
using System.ComponentModel;
using System.Windows.Media;
using System.Windows.Input;
using ColorSliders.ViewModel.Commands;

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

        private ICommand command;

        public ICommand Reset
        {
            get
            {
                if (command == null)
                    command = new ResetCMD(this);

                return command;
            }
        }

    }
}
