using MdelLib;
using Model;
using System.Collections.ObjectModel;
using VievModelLib;
using ViewModelLib.Commands;

namespace ViewModel
{
    public class MainViewModel: ViewModelBase
    {
        private MainModel _mineModel;
        public RelayCommand OpenListCommand { get; }
        public ObservableCollection<User>? Users => _mineModel.Users;
        public MainViewModel(MainModel mineModel)
        {
            _mineModel = mineModel;
            //OpenListCommand = new RelayCommand(() => Debug.WriteLine("Команда OpenListCommand"));
        }
        
        public void AddUser(User user) => _mineModel.AddUzer(user);
    }
}
