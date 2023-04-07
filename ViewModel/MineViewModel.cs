using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VievModelLib;
using ViewLib.Commands;

namespace ViewModel
{
    public class MineViewModel : ViewModelBase
    {
        public RelayCommand OpenListCommand { get; }
        public MineViewModel()
        {
            OpenListCommand = new RelayCommand(() => Debug.WriteLine("Команда работает!"));
        }
    }
}
