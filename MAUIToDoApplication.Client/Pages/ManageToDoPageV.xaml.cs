namespace MAUIToDoApplication.Client.Pages;

public partial class ManageToDoPageV : ContentPage
{
	public ManageToDoPageV(ManageToDoPageVM context)
	{
		InitializeComponent();
		BindingContext = context;
	}
}