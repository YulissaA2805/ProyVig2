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
    public partial class Page2 : ContentPage
    {
        private UserClass _user { get; set; }

        private string comportamiento1 = "";
        private string comportamiento2 = "";

        public Page2(UserClass user)
        {
            InitializeComponent();
            _user = user;
            BindingContext = _user;
        }
        void RadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton rbtn = (RadioButton)sender;
            
            if (rbtn.Value.Equals("Seguridad"))
            {
                comportamiento1 = "Seguridad";
            }
            else if (rbtn.Value.Equals("Ambiental"))
            {
                comportamiento1 = "Ambiental";
            }
            else if (rbtn.Value.Equals("Inseguro"))
            {
                comportamiento2 = "Inseguro";
            }
            else if (rbtn.Value.Equals("Seguro"))
            {
                comportamiento2 = "Seguro";
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(comportamiento1 == "Seguridad" && comportamiento2 == "Inseguro")
            {
                this.Navigation.PushAsync(new SeguridadInseguroPage(_user));//SeguridadInseguroPage
            }
            else if(comportamiento1 == "Seguridad" && comportamiento2 == "Seguro")
            {

            }
            else if (comportamiento1 == "Ambiental" && comportamiento2 == "Inseguro")
            {

            }
            else if (comportamiento1 == "Ambiental" && comportamiento2 == "Seguro")
            {

            }
            else
            {
                DisplayAlert("Error", "Debe especificar el comportamiento antes de avanzar.", "OK");
            }

        }
    }
}