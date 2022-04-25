using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProyectoVigilante2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var id = entryID.Text;
            var password = entryPassword.Text;
            if(string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
            {
                DisplayAlert("Error", "Debe ingresar un ID y una contraseña válidos.", "Aceptar");
            }
            else
            {
                var user = new UserClass
                {
                    Name = "Noa Edith Montes Sanchez",
                    Area = "GAM EHS",
                    TL = "Daniel Santamaría Guzman"
                };
                this.Navigation.PushAsync(new Page1(user));
            }
            
        }
    }
}
