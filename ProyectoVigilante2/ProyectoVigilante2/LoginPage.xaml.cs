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
        public bool esContratista = false;
        public string compañia = "";
        public MainPage()
        {
            InitializeComponent();

            var linkNoEmpleado_tap = new TapGestureRecognizer();
            linkNoEmpleado_tap.Tapped += (s, e) =>
            {
                ShowActionSheet(s, e);
            };
            linkNoEmpleado.GestureRecognizers.Add(linkNoEmpleado_tap);
        }

        public async void ShowActionSheet(object obj, EventArgs arg)
        {
            string action = await DisplayActionSheet("Soy un contratista de:", "Cancelar", null,
                    "MANPOWER", "CHS", "ADECCO", "JLL", "LIMPIEZA", "CEVA", "SEGUPROIN");
            //await DisplayAlert("Usted eligió:", action, "OK");
            switch (action)
            {
                case "MANPOWER":
                    entryID.Text = "10000000";
                    entryPassword.Text = "10000000";
                    break;
                case "CHS":
                    entryID.Text = "40000000";
                    entryPassword.Text = "40000000";
                    break;
                case "ADECCO":
                    entryID.Text = "30000000";
                    entryPassword.Text = "30000000";
                    break;
                case "JLL":
                    entryID.Text = "50000000";
                    entryPassword.Text = "50000000";
                    break;
                case "LIMPIEZA":
                    entryID.Text = "60000000";
                    entryPassword.Text = "60000000";
                    break;
                case "CEVA":
                    entryID.Text = "20000000";
                    entryPassword.Text = "20000000";
                    break;
                case "SEGUPROIN":
                    entryID.Text = "70000000";
                    entryPassword.Text = "70000000";
                    break;
            }
            compañia = action;
            esContratista = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var id = entryID.Text;
            var password = entryPassword.Text;
            if(string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
            {
                DisplayAlert("Error", "Debe ingresar una ID y una contraseña válidos.", "Aceptar");
            }
            else if (esContratista)
            {
                var user = new UserClass
                {
                    Name = "Contratista de " + compañia,
                    Area = "",
                    TL = "",
                    esContratista = true,
                    retroalimentacion = false
                };
                this.Navigation.PushAsync(new Page1(user));
            }
            else
            {
                var user = new UserClass
                {
                    Name = "Ana Legy",
                    Area = "GAM EHS",
                    TL = "Daniel Santamaría Guzman",
                    esContratista = false,
                    retroalimentacion = false
                };
                this.Navigation.PushAsync(new Page1(user));
            }
            
        }
    }
}
