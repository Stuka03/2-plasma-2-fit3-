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
        private bool BanderaBoxLS;
        public ConexionPhoenix()
        {
            SistemaCorte = CuttingSystem.Instance;
            BanderaBoxLS = true;
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
        public void TurnCncFunctionTrue(InputFunction f)
        {
            try
            {   //INICIAR CONEXION
                SistemaCorte.Inputs[f].SetState(true);

            }
            catch (Exception ex)
            {
                CncVariableEx(ex.Message, f);
            }
        }
        public void TurnCncFunctionFalse(InputFunction f)
        {
            try
            {
                SistemaCorte.Inputs[f].SetState(false);
            }
            catch (Exception ex)
            {
                CncVariableEx(ex.Message, f);
            }
        }
        public bool CheckCncFunctionState(InputFunction f)
        {
            try
            {
                return SistemaCorte.Inputs[f].State;
            }
            catch (Exception ex)
            {
                CncVariableEx(ex.Message, f);
                return false;
            }
        }
        public bool CheckCncOutputState(OutputFunction f)
        {
            try
            {
                return SistemaCorte.Outputs[f].State;
            }
            catch (Exception ex)
            {
                CncVariableExOut(ex.Message, f);
                return false;
            }
        }
        private void CncVariableExOut(string ex, OutputFunction f)
        {
            if (BanderaBoxLS == false)
            {
                BanderaBoxLS = true;
                customMessageBox.set_color_texto((ex) + "\nDar de alta la funcion: " + f.ToString(), Color.Red);
                customMessageBox.ShowDialog();
            }
        }
        private void CncVariableEx(string ex, InputFunction f)
        {
            if (BanderaBoxLS == false)
            {
                BanderaBoxLS = true;

                customMessageBox.set_color_texto((ex) + "\nDar de alta la funcion: " + f.ToString(), Color.Red);
                customMessageBox.ShowDialog();
            }
        }
        
    }
}
