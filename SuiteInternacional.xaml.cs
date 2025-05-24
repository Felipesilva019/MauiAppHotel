namespace MauiAppHotel;

public partial class SuiteInternacional : ContentPage
{

	App propriedadesApp;
	
	
	
	public SuiteInternacional()
	{
		InitializeComponent();
		var Lista = ((App)Application.Current).lista_local;
		pck_paises.ItemsSource = Lista;
		pck_cidade.ItemsSource = Lista;
	
	
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();

		} catch (Exception ex)
		{

			DisplayAlert("Ops", ex.Message, "Ok");

		}
    }
}