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
                    Image = "icono.png",
                    Color = "#D35400"
                },
                new Location
                {
                    Name = "ACOUSTIC BOND",
                    Image = "icono.png",
                    Color = "#DC7633"
                },
                new Location
                {
                    Name = "BOND CCA\nCLEAN ROOM",
                    Image = "icono.png",
                    Color = "#E67E22"
                },
                new Location
                {
                    Name = "BOND POST BOND",
                    Image = "icono.png",
                    Color = "#EB984E"
                },
                new Location
                {
                    Name = "BRAKE ROOM",
                    Image = "icono.png",
                    Color = "#F39C12"
                },
                new Location
                {
                    Name = "EH&S",
                    Image = "icono.png",
                    Color = "#F5B041"
                },
                new Location
                {
                    Name = "ENGINEERING",
                    Image = "icono.png",
                    Color = "#F1C40F"
                },
                new Location
                {
                    Name = "ENGINEERING\nDESIGN",
                    Image = "icono.png",
                    Color = "#F4D03F"
                },
                new Location
                {
                    Name = "FACILITIES",
                    Image = "icono.png",
                    Color = "#D35400"
                },
                new Location
                {
                    Name = "FINANCE",
                    Image = "icono.png",
                    Color = "#DC7633"
                },
                new Location
                {
                    Name = "GTF",
                    Image = "icono.png",
                    Color = "#E67E22"
                },
                new Location
                {
                    Name = "HUMAN\nRESOURCES",
                    Image = "icono.png",
                    Color = "#EB984E"
                },
                new Location
                {
                    Name = "HYDRO PRESS",
                    Image = "icono.png",
                    Color = "#F39C12"
                },
                new Location
                {
                    Name = "MAINTENANCE",
                    Image = "icono.png",
                    Color = "#F5B041"
                },
                new Location
                {
                    Name = "MANAGEMENT",
                    Image = "icono.png",
                    Color = "#F1C40F"
                },
                new Location
                {
                    Name = "MATERIALS\nOPERATIONS",
                    Image = "icono.png",
                    Color = "#F4D03F"
                },
                new Location
                {
                    Name = "NOSELIPS",
                    Image = "icono.png",
                    Color = "#D35400"
                },
                new Location
                {
                    Name = "NOSELIPS 360",
                    Image = "icono.png",
                    Color = "#DC7633"
                },
                new Location
                {
                    Name = "NUT PLATES",
                    Image = "icono.png",
                    Color = "#E67E22"
                },
                new Location
                {
                    Name = "ONLOAD",
                    Image = "icono.png",
                    Color = "#EB984E"
                },
                new Location
                {
                    Name = "PROCESSING",
                    Image = "icono.png",
                    Color = "#F39C12"
                },
                new Location
                {
                    Name = "PRODUCTION\nCONTROL",
                    Image = "icono.png",
                    Color = "#F5B041"
                },
                new Location
                {
                    Name = "PURCHASING",
                    Image = "icono.png",
                    Color = "#F1C40F"
                },
                new Location
                {
                    Name = "QUALITY",
                    Image = "icono.png",
                    Color = "#F4D03F"
                },
                new Location
                {
                    Name = "SECURITY",
                    Image = "icono.png",
                    Color = "#D35400"
                },
                new Location
                {
                    Name = "SHIPPING",
                    Image = "icono.png",
                    Color = "#DC7633"
                },
                new Location
                {
                    Name = "SPF",
                    Image = "icono.png",
                    Color = "#E67E22"
                },
                new Location
                {
                    Name = "STRETCH BEND",
                    Image = "icono.png",
                    Color = "#EB984E"
                },
                new Location
                {
                    Name = "TOOL SHOP",
                    Image = "icono.png",
                    Color = "#F39C12"
                },
                new Location
                {
                    Name = "TR GE",
                    Image = "icono.png",
                    Color = "#F5B041"
                },
                new Location
                {
                    Name = "TR RR",
                    Image = "icono.png",
                    Color = "#F1C40F"
                },
                new Location
                {
                    Name = "COMEDOR",
                    Image = "icono.png",
                    Color = "#F4D03F"
                },
                new Location
                {
                    Name = "ESTACIONAMIENTO",
                    Image = "icono.png",
                    Color = "#D35400"
                },
                new Location
                {
                    Name = "OFICINAS\nPLANTA ALTA",
                    Image = "icono.png",
                    Color = "#DC7633"
                },
                new Location
                {
                    Name = "OFICINAS\nPLANTA BAJA",
                    Image = "icono.png",
                    Color = "#E67E22"
                },
                new Location
                {
                    Name = "PATIOS",
                    Image = "icono.png",
                    Color = "#EB984E"
                },
                new Location
                {
                    Name = "PASILLOS\nPRODUCCIÓN",
                    Image = "icono.png",
                    Color = "#F39C12"
                },
                new Location
                {
                    Name = "SALAS DE\nREUNIONES",
                    Image = "icono.png",
                    Color = "#F5B041"
                },
                new Location
                {
                    Name = "BIZJET\nOPERATIONS",
                    Image = "icono.png",
                    Color = "#F1C40F"
                },
                new Location
                {
                    Name = "SPRINGSTEEN",
                    Image = "icono.png",
                    Color = "#F4D03F"
                }
            };
        }
    }
}
