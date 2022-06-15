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
    public partial class Page5 : ContentPage
    {
        private UserClass _user { get; set; }

        public Page5(UserClass user)
        {
            InitializeComponent();
            _user = user;
            BindingContext = _user;

            FormLugar.Text = "Lugar: (dato sobre la locación)";
            FormComp.Text = "Comportamiento: (datos del comportamiento)";
            FormCond.Text = "Condición de riesgo: (datos de la condición)";
            FormObserv.Text = "Se observó: (características del comportamiento observado)";
            FormResponsable.Text = "Persona observada: (ID o nombre)";

            FormCond.IsVisible = false;

            if (_user.retroalimentacion)
            {
                checkRetroalimentacion.IsChecked = true;
            }

            if(_user.datosFormUsuario.CompInseguro == "X")
            {
                FormComp.Text = "Comportamiento: Inseguro";
            }
            else if (_user.datosFormUsuario.CompInseguroAmbiental == "X")
            {
                FormComp.Text = "Comportamiento: Ambiental Inseguro";
            }
            else if (_user.datosFormUsuario.CompSeguro == "X")
            {
                FormComp.Text = "Comportamiento: Seguro";
            }
            else if (_user.datosFormUsuario.CompSeguroAmbiental == "X")
            {
                FormComp.Text = "Comportamiento: Ambiental Seguro";
            }

            if (_user.datosFormUsuario.CondOComp.Equals("Condición"))
            {
                labelRetroalimentacion.IsVisible = false;
                checkRetroalimentacion.IsVisible = false;
                FormComp.IsVisible = false;
                FormObserv.IsVisible = false;
                FormResponsable.IsVisible = false;

                FormCond.IsVisible = true;
                FormCond.Text = "Condición de riesgo: " + _user.datosFormUsuario.CondicionX;
            }

            if (_user.datosFormUsuario.EmpleadoVigilado != "")
            {
                FormResponsable.Text = "ID de la persona vigilada: " + _user.datosFormUsuario.EmpleadoVigilado;
            }
            else
            {
                FormResponsable.Text = "Nombre de la persona vigilada: " + _user.datosFormUsuario.NombreVisitanteOContratista;
            }
            
        }

        private void Button_Clicked(object sender, EventArgs e)//ENVIAR
        {
            if (!checkRetroalimentacion.IsChecked && _user.datosFormUsuario.CondOComp.Equals("Comportamiento"))
            {
                DisplayAlert("Retroalimente al compañero", "Antes de enviar los datos, " +
                    "debe decirle a la persona observada cómo " +
                    "mejorar su comportamiento para que el incidente no vuelva a ocurrir.", "Aceptar");
            }
            else
            {
                DisplayAlert("Enviado con éxito", "Gracias por usar Vigilante.", "Aceptar");
            }
        }

        private void checkRetroalimentacion_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            _user.retroalimentacion = ((CheckBox)sender).IsChecked;
        }
    }
}