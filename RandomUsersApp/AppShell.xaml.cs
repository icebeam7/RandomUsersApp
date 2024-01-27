using RandomUsersApp.Views;

namespace RandomUsersApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(Helpers.Constants.UserDetailsRoute, typeof(UserDetailsView));
        }
    }
}
