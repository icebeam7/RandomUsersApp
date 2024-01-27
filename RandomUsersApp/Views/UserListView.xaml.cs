using RandomUsersApp.ViewModels;

namespace RandomUsersApp.Views;

public partial class UserListView : ContentPage
{
	public UserListView(UserListViewModel vm)
	{
		InitializeComponent();
        this.BindingContext = vm;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        var vm = BindingContext as UserListViewModel;

        if (vm != null)
            await vm.GetUsersCommand.ExecuteAsync(null);
    }
}