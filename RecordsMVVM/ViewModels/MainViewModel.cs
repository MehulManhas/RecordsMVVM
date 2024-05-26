using RecordsMVVM.Commands;
using RecordsMVVM.Models;
using RecordsMVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RecordsMVVM.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }
        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            Users = UserManager.GetUsers();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private void ShowWindow(object obj)
        {
            var mainWindow = (MainWindow)obj;
            AddUser addUser = new AddUser();
            addUser.Owner = mainWindow;
            addUser.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addUser.Show();
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }
    }
}
