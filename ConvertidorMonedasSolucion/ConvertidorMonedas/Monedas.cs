using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertidorMonedas
{
    public class Serie
    {
        public DateTime fecha { get; set; }
        public double valor { get; set; }
    }

    public class Monedas
    {
        public string version { get; set; }
        public string autor { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public List<Serie> serie { get; set; }
    }
}
