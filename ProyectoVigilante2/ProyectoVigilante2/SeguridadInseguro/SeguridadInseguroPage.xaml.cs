using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoVigilante2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeguridadInseguroPage : ContentPage
    {
        private UserClass _user { get; set; }
        public SeguridadInseguroPage(UserClass user)
        {
            InitializeComponent();
            _user = user;
            BindingContext = _user;
        }

        void Otro_Completed(object sender, EventArgs e)
        {
            var text_otro = ((Entry)sender).Text;
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton rbtn = (RadioButton)sender;

            if (rbtn.Content.Equals("Otro"))
            {
                Otro.IsVisible = true;
                EquipoInadecuado.IsVisible = false;
                COVID.IsVisible = false;
                COVID.Text = "";
            }
            else if(rbtn.Content.Equals("Incumplimiento en protocolo COVID"))
            {
                Otro.IsVisible = false;
                Otro.Text = "";
                EquipoInadecuado.IsVisible = false;

                COVID.IsVisible = true;
            }
            else if (rbtn.Content.Equals("Uso inadecuado de EPP"))
            {
                Otro.IsVisible = false;
                Otro.Text = "";
                COVID.IsVisible = false;
                COVID.Text = "";

                EquipoInadecuado.IsVisible = true;
            }
            else
            {
                Otro.IsVisible = false;
                Otro.Text = "";
                EquipoInadecuado.IsVisible = false;
                COVID.IsVisible = false;
                COVID.Text = "";
            }
        }

        private void Button_Clicked(object sender, EventArgs e)//Siguiente
        {
            if((Otro.IsVisible && Otro.Text == "") || (COVID.IsVisible && COVID.Text == ""))
            {
                DisplayAlert("Error", "Debe llenar todas las especificaciones sobre" +
                    " el comportamiento observado antes de avanzar.", "Aceptar");
            }
            else
            {
                this.Navigation.PushAsync(new Page4(_user));
            }
            
        }

        private void COVID_Completed(object sender, EventArgs e)
        {
            var text_COVID = ((Entry)sender).Text;
        }

        private void RadioButton_CheckedChanged_1(object sender, CheckedChangedEventArgs e)
        {//Equipo Inadecuado EPP

        }

        private void cbEstado_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (cbEstado1.IsChecked)
            {
                
            }
        }
    }
}