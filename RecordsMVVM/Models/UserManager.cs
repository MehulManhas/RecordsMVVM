using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsMVVM.Models
{
    public class UserManager
    {
        public static ObservableCollection<User> UserCollection = new ObservableCollection<User>() { new User("Mehul", "mehulmanhas@gmail.com"), new User("Mehul Manhas", "mehul@gmail.com") };
        public static ObservableCollection<User> GetUsers()
        {
            return UserCollection;
        }
        public static void AddUser(User User)
        {
            UserCollection.Add(User);
        }
    }
}
