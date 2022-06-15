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
    public partial class ComportamientoOCondicion : ContentPage
    {
        private UserClass _user { get; set; }
        private bool esComportamiento;

        public ComportamientoOCondicion(UserClass user)
        {
            InitializeComponent();
            _user = user;
            BindingContext = _user;
            esComportamiento = false;
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton rbtn = (RadioButton)sender;

            if (rbtn.Value.Equals("Comportamiento"))
            {
                esComportamiento = true;
                pickerCondicion.IsVisible = false;
                _user.datosFormUsuario.CondOComp = "Comportamiento";
            }
            else
            {
                esComportamiento = false;
                pickerCondicion.IsVisible = true;
                _user.datosFormUsuario.CondOComp = "Condición";
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(esComportamiento)
                this.Navigation.PushAsync(new Page2(_user));
            else
                this.Navigation.PushAsync(new Page5(_user));
        }

        private void pickerCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                _user.datosFormUsuario.CondicionX = picker.Items[selectedIndex];
            }
        }
    }
}