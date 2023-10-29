using MAUIToDoApplication.Client.Pages;

namespace MAUIToDoApplication.Client
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ManageToDoPageV), typeof(ManageToDoPageV));
        }
    }
}