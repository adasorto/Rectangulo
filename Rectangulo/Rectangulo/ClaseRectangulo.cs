using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo
{
    class ClaseRectangulo
    {
        private string ax;
        private string ay;

        private string bx;
        private string by;

        private string cx;
        private string cy;

        private string dx;
        private string dy;

        private string altura;
        private string base1;
        private string primetro;
        private string area;
        private bool validar;
        private string resustado;

        public string AX
        {
            get { return ax; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);
                if (resultado) ax = value;
                OnPropertyChanged("AX");
                OnPropertyChanged("Altura");
                OnPropertyChanged("Base");
            }
        }
    }
}
