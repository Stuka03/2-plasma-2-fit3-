using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace InterfaceOneStation.Acciones.Lubricasion
{

    internal class Lubricasion
    {
        CuttingSystem objCutting;
        public Lubricasion() {
             objCutting=CuttingSystem.Instance;
        }
        public void PruebaLibricasion()
        {
           
        }
    }
}
