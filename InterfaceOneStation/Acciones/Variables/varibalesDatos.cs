using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOneStation.Acciones.Variables
{
    internal class varibalesDatos
    {
        public Dictionary<string, dynamic> datos=new Dictionary<string, dynamic>();
        public varibalesDatos()
        {
            datos["LubricationEnabled"] = true;
            datos["IntervalTime"] = 0;
            datos["ActivationTime"] = 0;
        }
    }
}
