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
        }

        private void Button_Clicked(object sender, EventArgs e)//ENVIAR
        {
            DisplayAlert("Enviado con éxito", "Gracias por usar Vigilante.", "OK");
        }
    }
}