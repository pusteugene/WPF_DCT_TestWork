using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_DCT_TestWork.DB;
using WPF_DCT_TestWork.Model;
using WPF_DCT_TestWork.Services;

namespace WPF_DCT_TestWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            IDataService<User> userService = new GenericDataService<User>(new DBContextFactory());
            userService.Create(new User { UserName = "Test" }).Wait();
            ListBoxUsers.Items.Add(userService.GetAll());
            InitializeComponent();
        }
    }
}
