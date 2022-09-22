using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using WPF_DCT_TestWork.Command;
using WPF_DCT_TestWork.Models;
using WPF_DCT_TestWork.ViewsModels;

namespace WPF_DCT_TestWork.State.Navigators
{
    public enum ViewType
    {
        Home,
        Account,
        Buy,
        Sell
    }
    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel 
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
