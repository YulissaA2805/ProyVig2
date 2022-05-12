using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoVigilante2.SeguridadSeguro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeguridadSeguroPage : ContentPage
    {
        private UserClass _user { get; set; }
        public SeguridadSeguroPage(UserClass user)
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
            }
            else
            {
                Otro.IsVisible = false;
                Otro.Text = "";
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Otro.IsVisible && Otro.Text == "")
            {
                DisplayAlert("Error", "Debe especificar" +
                    " el comportamiento observado antes de avanzar.", "Aceptar");
            }
            else
            {
                this.Navigation.PushAsync(new Page4(_user));
            }
            
        }
    }
}