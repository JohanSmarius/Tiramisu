using TiramisuApp.Models;
using TiramisuApp.ViewModels;

namespace TiramisuApp;

public partial class OpenRequests : ContentPage
{
	public OpenRequests()
	{
		InitializeComponent();

        BindingContext = new OpenRequestsViewModel();
	}

   
}