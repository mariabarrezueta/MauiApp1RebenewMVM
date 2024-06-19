using MauiApp1RebenewMVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1RebenewMVM.Services
{
    public class LibroServiceRebe: ILibroServiceRebe
    {
        public List<LibroRebe>ObtenerLibro()
        {
            //Creacion temporal de datos en memoria
            return new List<LibroRebe>
            {
              new LibroRebe { Titulo = "Libro 1", Autor = "Autor 1" },
              new LibroRebe { Titulo = "Libro 2", Autor = "Autor 2" },
              new LibroRebe { Titulo = "Libro 3", Autor = "Autor 3" }

             };
         }
    }
}
