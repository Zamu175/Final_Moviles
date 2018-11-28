using System;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using Fina_Moviles.Instagram.Model;
using Fina_Moviles.Instagram.Resources;
using System.Text;

namespace Fina_Moviles.Instagram.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private async void Ingresar_Click(object sender, EventArgs e)
        {
            var usuario = Usuario.Text;
            var password = Password.Text;

            if (string.IsNullOrEmpty(usuario))
            {
                await DisplayAlert("Validación", AppResources.ValidacionUsuario, "OK");
                Usuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Validación", AppResources.ValidacionContrasena, "OK");
                Usuario.Focus();
                return;
            }

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://misapis.azurewebsites.net");

            var autenticacion = new Autenticacion
            {
                Usuario = usuario,
                Password = password
            };

            string json = JsonConvert.SerializeObject(autenticacion);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var request = await client.PostAsync("/api/Seguridad", content);
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var respuesta = JsonConvert.DeserializeObject<Respuesta>(responseJson);

                if (respuesta.EsPermitido)
                {
                    await Navigation.PushAsync(new PrincipalPage());
                }
                else
                {
                    await DisplayAlert("Lo sentimos!", respuesta.Mensaje, "Aceptar");
                }
            }
            else
            {
                await DisplayAlert("Lo sentimos!", "Ha ocurrido un error de comunicacion", "OK");
            }
        }
    }
}