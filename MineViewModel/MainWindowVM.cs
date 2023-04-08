
using Model;
using ModelLib;
using System.Collections.ObjectModel;
using VievModelLib;
using ViewModelLib.Commands;

namespace ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly MainModel mineModel;
        public RelayCommand AddUserCommand { get; }
        public ReadOnlyObservableCollection<User> Users => mineModel.Users;
        public MainViewModel(MainModel mineModel)
        {
            this.mineModel = mineModel;
            AddUserCommand = new RelayCommand<User>
            (
                user => mineModel.AddUzer(user),
                user => !(string.IsNullOrWhiteSpace(user.Name) ||
                          string.IsNullOrWhiteSpace(user.Family) ||
                          string.IsNullOrWhiteSpace(user.Job)));
        }

        // Только для режима разработки
        public MainViewModel()
        {
            mineModel = new();
            AddUserCommand = new RelayCommand(() => { });
        }
    }
}
