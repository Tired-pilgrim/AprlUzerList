using MdelLib;
using System;
using System.Diagnostics;
using VievModelLib;
using ViewModelLib.Commands;

namespace ViewModel
{
    public class AddUzerDC: ViewModelBase
    {
        private MainViewModel _mineVM;
        public AddUzerDC(MainViewModel mineVM)
        {
            _mineVM = mineVM;   
            ClickAddUserCommand = new RelayCommand(() => OnClickAddUserCommand(),
                CanClickAddCommandEcxecute);
            _mineVM = mineVM;
        }
        private void OnClickAddUserCommand()
        {
            User _uzer = new User()
            { Name = _name, Family = _family, Job = _job };
            _mineVM.AddUser(_uzer);
        }

        public RelayCommand ClickAddUserCommand { get; }
        private bool CanClickAddCommandEcxecute() =>
            !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Family) &&
            !string.IsNullOrWhiteSpace(Job);
       
        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set => Set(ref _name, ref value);
        }

        private string _family = string.Empty;
        public string Family
        {
            get => _family;
            set => Set(ref _family, ref value);
        }
        private string _job = string.Empty;

        public string Job
        {
            get => _job;
            set => Set(ref _job, ref value);
        }
    }
}
