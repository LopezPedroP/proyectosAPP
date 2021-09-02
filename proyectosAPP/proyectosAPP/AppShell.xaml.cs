using proyectosAPP.ModelosdePaginas;
using proyectosAPP.ViewModels;
using proyectosAPP.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace proyectosAPP
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("PaginaUno", typeof(PaginaUno));
            Routing.RegisterRoute("PaginaDos", typeof(PaginaDos));
            Routing.RegisterRoute("PaginaTres", typeof(PaginaTres));
        }

    }
}
