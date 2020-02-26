using System;
using System.Windows.Input;

namespace UnoApp1.Shared
{
    class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Action<object> Action { get; set; }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => Action?.Invoke(parameter);
    }
}