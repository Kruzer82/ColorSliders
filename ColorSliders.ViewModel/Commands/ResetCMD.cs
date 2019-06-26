using System;
using System.Windows.Input;

namespace ColorSliders.ViewModel.Commands
{

    /// <summary>
    /// Sets RGB sliders value to 0.
    /// </summary>
    public class ResetCMD : ICommand
    {
        private readonly RectangleColor viewModel;
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public ResetCMD(RectangleColor viewModel)
        {
            if (viewModel == null)
                throw new ArgumentNullException("viewModel");

            this.viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return (viewModel.RedSlider != 0) || (viewModel.GreenSlider != 0) || (viewModel.BlueSlider != 0);
        }

        public void Execute(object parameter)
        {
                viewModel.RedSlider = 0;
                viewModel.GreenSlider = 0;
                viewModel.BlueSlider = 0;
        }

       
    }
}
