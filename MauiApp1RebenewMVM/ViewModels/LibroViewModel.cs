using MauiApp1RebenewMVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1RebenewMVM.ViewModels
{
    public class LibroViewModel : INotifyPropertyChanged
    {
        private LibroRebe _libro;
        public LibroRebe Libro
        {
            get { return _libro; }
            set
            {
                _libro = value;
                onPropertyChanged(nameof(Libro));
            }
        }
        public List<LibroRebe> Libros { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void onPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
