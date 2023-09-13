using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;
using MatchMaker.Models;

namespace MatchMaker.ViewModel
{
    public partial class UserViewModel : ObservableObject
    {
        [ObservableProperty]
        private User user;

        public UserViewModel()
        {
            user = new User();
        }
    }
}
