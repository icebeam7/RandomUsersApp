using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

using RandomUsersApp.Models;
using RandomUsersApp.Helpers;
using RandomUsersApp.Services;

namespace RandomUsersApp.ViewModels
{
    public partial class UserListViewModel : BaseViewModel
    {
        public ObservableCollection<User> Users { get; } = new();

        [ObservableProperty]
        User selectedUser;

        IUserService userService;

        public UserListViewModel(IUserService userService)
        {
            Title = "User List";
            this.userService = userService;
        }

        [RelayCommand]
        private async Task GetUsersAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;

                var users = await userService.GetUsers();

                if (users != null)
                {
                    if (Users.Count != 0)
                        Users.Clear();

                    foreach (var user in users)
                        Users.Add(user);
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task GoToDetails()
        {
            if (SelectedUser == null)
                return;

            var data = new Dictionary<string, object>
            {
                { "UserDetails", SelectedUser }
            };

            await Shell.Current.GoToAsync(Constants.UserDetailsRoute, true, data);
        }
    }
}
