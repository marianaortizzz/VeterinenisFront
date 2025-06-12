namespace Veterinaria;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private void onClick(object sender, EventArgs e)
	{
		var boton = (Button)sender;

		// Cambia el color del botón al hacer clic
		boton.BackgroundColor = Color.FromArgb("#899878");


    }
}