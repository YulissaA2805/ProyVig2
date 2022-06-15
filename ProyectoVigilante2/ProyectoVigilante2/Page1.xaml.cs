using ProyectoVigilante2.ViewModels;
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
    public partial class Page1 : ContentPage
    {
        private UserClass _user { get; set; }
        public Page1(UserClass user)
        {
            InitializeComponent();
            _user = user;
            //BindingContext = _user;
            BindingContext = new Page1ViewModel();
            NombreEmpleado.Text = "Nombre: "+_user.Name;
            AreaEmpleado.Text = "Área: " + _user.Area;
            TLEmpleado.Text = "TL: " + _user.TL;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Page2(_user));
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _user.datosFormUsuario.AreaObservada = "";
            //string current = e.CurrentSelection.FirstOrDefault() as Locations;
            this.Navigation.PushAsync(new ComportamientoOCondicion(_user));
            
        }
    }
}