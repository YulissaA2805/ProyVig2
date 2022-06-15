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
    public partial class Page4 : ContentPage
    {
        private UserClass _user { get; set; }

        public Page4(UserClass user)
        {
            InitializeComponent();
            _user = user;
            BindingContext = _user;

            idPersona.Text = "";
            nombrePersona.Text = "";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(idPersona.Text != "")
            {
                _user.datosFormUsuario.EmpleadoVigilado = idPersona.Text;
                _user.datosFormUsuario.NombreVisitanteOContratista = "";
                this.Navigation.PushAsync(new Page5(_user));
            }
            else if(nombrePersona.Text != "")
            {
                _user.datosFormUsuario.NombreVisitanteOContratista = nombrePersona.Text;
                _user.datosFormUsuario.EmpleadoVigilado = "";
                this.Navigation.PushAsync(new Page5(_user));
            }
            else
            {
                DisplayAlert("Error", "Debe especificar el ID o nombre de la persona antes de avanzar." +
                    " Si no lo sabe, pregúntele a la persona en cuestión.", "Aceptar");
            }
            
        }

        private void tipoPersona_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (tipoPersona.IsChecked)
            {
                idPersona.IsVisible = false;
                nombrePersona.IsVisible = true;

                idPersona.Text = "";
            }
            else
            {
                idPersona.IsVisible = true;
                nombrePersona.IsVisible = false;

                nombrePersona.Text = "";
            }
        }

        private void idPersona_Completed(object sender, EventArgs e)
        {
            _user.datosFormUsuario.EmpleadoVigilado = ((Entry)sender).Text;
        }

        private void nombrePersona_Completed(object sender, EventArgs e)
        {
            _user.datosFormUsuario.NombreVisitanteOContratista = ((Entry)sender).Text;
        }

        private void nombrePersona_TextChanged(object sender, TextChangedEventArgs e)
        {
            _user.datosFormUsuario.NombreVisitanteOContratista = ((Entry)sender).Text;
        }

        private void idPersona_TextChanged(object sender, TextChangedEventArgs e)
        {
            _user.datosFormUsuario.EmpleadoVigilado = ((Entry)sender).Text;
        }
    }
}