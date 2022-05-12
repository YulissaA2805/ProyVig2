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
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Page5(_user));
        }

        private void tipoPersona_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (tipoPersona.IsChecked)
            {
                idPersona.IsVisible = false;
                nombrePersona.IsVisible = true;
            }
            else
            {
                idPersona.IsVisible = true;
                nombrePersona.IsVisible = false;
            }
        }

        private void idPersona_Completed(object sender, EventArgs e)
        {
            var text_idPersona = ((Entry)sender).Text;
        }

        private void nombrePersona_Completed(object sender, EventArgs e)
        {
            var text_nombrePersona = ((Entry)sender).Text;
        }
    }
}