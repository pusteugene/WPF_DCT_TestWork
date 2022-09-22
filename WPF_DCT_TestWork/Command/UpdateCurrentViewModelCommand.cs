using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPF_DCT_TestWork.State.Navigators;
using WPF_DCT_TestWork.ViewsModels;

namespace WPF_DCT_TestWork.Command
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private INavigator _navigation;

        public UpdateCurrentViewModelCommand(INavigator navigation)
        {
            _navigation = navigation;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Home:
                        _navigation.CurrentViewModel = new HomeViewModel();
                        break;
                    case ViewType.Account:
                        _navigation.CurrentViewModel = new AccountViewModel();
                        break;
                    case ViewType.Buy:
                        _navigation.CurrentViewModel = new BuyViewModel();
                        break;
                    case ViewType.Sell:
                        _navigation.CurrentViewModel = new SellViewModel();
                        break;
                }
            }
        }
    }
}