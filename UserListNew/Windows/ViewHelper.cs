using System.Windows;
using System.Windows.Controls;
using ViewModel;

namespace Views.Windows
{
    public static class ViewHelper
    {
        public static RoutedEventHandler MyClicker { get; } = (s, _) =>
        {             
            Window? currWin = Window.GetWindow(s as Button);
            // Дальше работает с currWin и их контекстами данных.;
           if (currWin.DataContext != null)
            {
                AddUzer _addUzer = new AddUzer()
                {
                    DataContext = new AddUzerDC(((MainViewModel)currWin.DataContext)),
                    Owner = currWin,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                };
                _addUzer.ShowDialog();
            }
        };
    }
}
