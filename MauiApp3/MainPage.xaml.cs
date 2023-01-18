namespace MauiApp3;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    public async Task CheckInternetConnectivity()
    {
        NetworkAccess accessType = Connectivity.Current.NetworkAccess;

        if (accessType == NetworkAccess.Internet)
        {
            bool answer = await DisplayAlert("Connectivity Info", "You do not have internet connection" + "\n" + "Show your Offline Card??", "Yes", "No");

            if (answer == true)
            {
                await Shell.Current.GoToAsync(state: "OfflineCard");
            }
        }

    }


  

}

