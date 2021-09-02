using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace proyectosAPP.ViewModels
{
    
    public class CommadClass
    {
        public Command PaginaUnoGo { get; set; }
        public Command PaginaDosGo { get; set; }
        public Command PaginaTresGo { get; set; }
        public CommadClass()
        {
            PaginaUnoGo = new Command(Paginauno);
            PaginaDosGo = new Command(Paginados);
            PaginaTresGo = new Command(Paginatres);
        }

        private async void Paginauno(object obj)
        {
            await Shell.Current.GoToAsync("PaginaUno");
        }
        private async void Paginados(object obj)
        {
            await Shell.Current.GoToAsync("PaginaDos");
        }
        private async void Paginatres(object obj)
        {
            await Shell.Current.GoToAsync("PaginaTres");
        }

        
    }
}
