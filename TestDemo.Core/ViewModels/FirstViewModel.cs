using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace TestDemo.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        /*private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }*/

        private string _name = "Hello MvvmCross";
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value != _name)
                {
                    _name = value;
                    RaisePropertyChanged(() => Name);
                }
            }
        }

        private string _hello = "Hello MvvmCross";
        public string Hello
        {
            get { return _hello; }
            set
            {
                if (value != null && value != _hello)
                {
                    _hello = value;
                    RaisePropertyChanged(() => Hello);
                }
            }
        }

        private double sliderValue;
        public double SliderValue
        {
            get { return sliderValue; }
            set
            {
                SetProperty(ref sliderValue, value);
            }
        }

        public ICommand ButtonCommand { get; private set; }
        public FirstViewModel()
        {
            ButtonCommand = new MvxCommand(() =>
            {
                Hello = "Button has been pressed!!!";
            });
        }

    }
}
