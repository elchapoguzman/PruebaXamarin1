using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Formulario : ContentPage
	{
		public Formulario ()
		{
			InitializeComponent ();
            loginButton.Clicked += LoginButton_Clicked;
        }
        async void LoginButton_Clicked(object sender, EventArgs e)
        {
            string nombre = userEntry.Text;
            string pass = passEntry.Text;
            string rut = rutEntry.Text;
            string email = emailEntry.Text;
            string passc = passcEntry.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                await DisplayAlert("Error", "Ingrese usuario", "Aceptar");
                userEntry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(rut))
            {
                await DisplayAlert("Error", "Ingrese RUT", "Aceptar");
                rutEntry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pass))
            {
                await DisplayAlert("Error", "Debe ingresar Password", "Aceptar");
                passEntry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(passc))
            {
                await DisplayAlert("Error", "Debe repetir su contraseña", "Aceptar");
                passEntry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                await DisplayAlert("Error", "Debe ingresar un Email", "Aceptar");
                emailEntry.Focus();
                return;
            }
            if (pass==passc)
            {
                await DisplayAlert("Error", "Sus contraseñas deben coincidir", "Aceptar");
                passcEntry.Focus();
                return;
            }
        }

    }
}