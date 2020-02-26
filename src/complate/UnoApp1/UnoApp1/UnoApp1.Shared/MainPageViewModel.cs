using System.ComponentModel;

namespace UnoApp1.Shared
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Box1 { get; set; }
        public string Box2 { get; set; }

        public string Block1 { get; set; }

        public Command Click { get; } = new Command();

        public MainPageViewModel() => Click.Action = OnClicked;

        void OnClicked(object parameter)
        {
            Block1 = $"{Box1}{Box2}";
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Block1)));
        }
    }
}