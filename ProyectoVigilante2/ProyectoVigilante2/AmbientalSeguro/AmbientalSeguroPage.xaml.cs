using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoVigilante2.AmbientalSeguro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AmbientalSeguroPage : ContentPage
    {
        private UserClass _user { get; set; }
        public AmbientalSeguroPage(UserClass user)
        {
            InitializeComponent();
            _user = user;
            BindingContext = _user;
        }
    }
}