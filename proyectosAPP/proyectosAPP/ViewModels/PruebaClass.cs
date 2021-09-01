using System;
using System.Collections.Generic;
using System.Text;

namespace proyectosAPP.ViewModels
{
    public class PruebaClass
    {
        public string Name { get; set; }
        public string Dato { get; set; }
        public string Info { get; set; }
    }
    
    public class Pruebas
    {
        public List<PruebaClass> Pruebasa { get; set; } = new List<PruebaClass>();
        public Pruebas()
        {
            Pruebasa.Add(new PruebaClass { Name = "Tab 1", Dato = "presentando informacion", Info = "esto es un tab bindeable"});
            Pruebasa.Add(new PruebaClass { Name = "Tab 2", Dato = "desarrollando informacion", Info = "esto es un tab bindeable opcion dos" });
        }
    }
}
