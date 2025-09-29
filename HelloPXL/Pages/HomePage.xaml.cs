using System.Threading.Tasks;

namespace HelloPXL.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	public async void MenuClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(MenuPage));
	}

	public async void AboutClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(AboutPage));
    }
}