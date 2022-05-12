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

            if (_user.retroalimentacion)
            {
                checkRetroalimentacion.IsChecked = true;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)//ENVIAR
        {
            if (!_user.retroalimentacion)
            {
                DisplayAlert("Retroalimente al compañero", "Antes de enviar los datos, " +
                    "debe decirle a la persona observada cómo" +
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