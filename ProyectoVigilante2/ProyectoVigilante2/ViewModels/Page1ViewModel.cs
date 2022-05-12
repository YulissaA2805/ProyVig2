using ProyectoVigilante2.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProyectoVigilante2.ViewModels
{
    public class Page1ViewModel
    {
        public ObservableCollection<Location> Locations { get; set; }

        public Page1ViewModel()
        {
            Locations = new ObservableCollection<Location>
            {
                new Location
                {
                    Name = "ACE",
                    Image = ""
                },
                new Location
                {
                    Name = "ACOUSTIC BOND",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "BOND CCA CLEAN ROOM",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "BOND POST BOND",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "BRAKE ROOM",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "EH&S",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "ENGINEERING",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "ENGINEERING DESIGN",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "FACILITIES",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "FINANCE",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "GTF",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "HUMAN RESOURCES",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "HYDRO PRESS",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "MAINTENANCE",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "MANAGEMENT",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "MATERIALS OPERATIONS",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "NOSELIPS",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "NOSELIPS 360",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "NUT PLATES",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "ONLOAD",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "PROCESSING",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "PRODUCTION CONTROL",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "PURCHASING",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "QUALITY",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "SECURITY",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "SHIPPING",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "SPF",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "STRETCH BEND",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "TOOL SHOP",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "TR GE",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "TR RR",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "COMEDOR",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "ESTACIONAMIENTO",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "OFICINAS PLANTA ALTA",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "OFICINAS PLANTA BAJA",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "PATIOS",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "PASILLOS PRODUCCIÓN",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "SALAS DE REUNIONES",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "BIZJET OPERATIONS",
                    Image = "icono.png"
                },
                new Location
                {
                    Name = "SPRINGSTEEN",
                    Image = "icono.png"
                }
            };
        }
    }
}
