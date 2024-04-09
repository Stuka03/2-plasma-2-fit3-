using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace InterfaceOneStation.Acciones.ConexionPhoenix
{
    public class ConexionPhoenix
    {
        public CuttingSystem SistemaCorte;
        CustomMessageBox customMessageBox = new CustomMessageBox();
        public ConexionPhoenix()
        {
            SistemaCorte = CuttingSystem.Instance;
            _IniciaConexionPhoenix();
        }

        private void _IniciaConexionPhoenix()
        {
            try
            {   //INICIAR CONEXION
                SistemaCorte = CuttingSystem.Instance;
                do
                {
                    SistemaCorte.GetAssignedIO();
                } while (SistemaCorte.Inputs.Count <= 0 &&
                SistemaCorte.Outputs.Count <= 0);
                //SINCRONIZAR
                SistemaCorte.SetSyncTimerTick(0.5);
                SistemaCorte.StartSync();
                SistemaCorte.Synchronize();
            }
            catch (Exception ex)
            {
                
                customMessageBox.set_color_texto("Falló conexion con Phoenix!", Color.Red);
                customMessageBox.ShowDialog();
            }
        }
    }
}
