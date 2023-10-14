namespace MAUIToDoApplication.Client.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(object context)
        {
            InitializeComponent();
            BindingContext = context;
        }
    }
}