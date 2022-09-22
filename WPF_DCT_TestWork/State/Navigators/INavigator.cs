using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WPF_DCT_TestWork.ViewsModels;

namespace WPF_DCT_TestWork.State.Navigators
{
    public interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
