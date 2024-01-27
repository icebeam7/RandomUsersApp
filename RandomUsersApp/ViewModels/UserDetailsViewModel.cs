using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

using RandomUsersApp.Models;
using RandomUsersApp.Helpers;
using RandomUsersApp.Services;

namespace RandomUsersApp.ViewModels
{
    [QueryProperty(nameof(User), "UserDetails")]
    public partial class UserDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        User user;



    }
}
