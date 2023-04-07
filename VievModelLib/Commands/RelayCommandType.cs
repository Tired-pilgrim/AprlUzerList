﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelLib.Commands
{
    /// <summary>Реализация RelayCommand для методов с обобщённым параметром.</summary>
    /// <typeparam name="T">Тип параметра методов.</typeparam>
     #region Делегаты для методов WPF команд
    public delegate void ExecuteHandler<T>(T parameter);
    public delegate bool CanExecuteHandler<T>(T parameter);
    #endregion
    public class RelayCommand<T> : RelayCommand
    {
        /// <inheritdoc cref="RelayCommand(ExecuteHandler, CanExecuteHandler)"/>
        public RelayCommand(ExecuteHandler<T> execute, CanExecuteHandler<T> canExecute = null)
            : base
            (
                  p =>
                  {
                      if (p is T t)
                          execute(t);
                  },
                  p => (p is T t) && (canExecute?.Invoke(t) ?? true)
            )
        { }
    }
}
