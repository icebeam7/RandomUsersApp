using RandomUsersApp.ViewModels;

namespace RandomUsersApp.Views;

public partial class UserDetailsView : ContentPage
{
	public UserDetailsView(UserDetailsViewModel vm)
	{
		InitializeComponent();

        this.BindingContext = vm;
    }
}