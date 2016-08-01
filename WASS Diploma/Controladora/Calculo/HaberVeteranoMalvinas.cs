using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Calculo
{
    public class HaberVeteranoMalvinas : CalculoStrategy
    {
        public override DatosCalculo RealizarCalculo(DatosCalculo pDatos)
        {

            pDatos.txtPrestacionCompensatoria = CalcularHaberVeterano(pDatos);
                        return pDatos;

        }


        //Calcular HABER Veterano
        private string CalcularHaberVeterano(DatosCalculo pDatos)
        {

            if (pDatos.PCm != 0 || pDatos.PCn != 0 || pDatos.PCp != 0)
            {
                pDatos.PC = (Convert.ToDecimal(0.015) * pDatos.PCN) * (((pDatos.PCn + pDatos.PCp) * pDatos.PCW + (pDatos.PCm + pDatos.PCp) * pDatos.PCR) / (pDatos.PCn + pDatos.PCm + pDatos.PCp));


                pDatos.PC = Decimal.Round(pDatos.PC, 2);
                pDatos.txtPrestacionCompensatoria = "$ " + pDatos.PC.ToString();
                return pDatos.txtHaberVeterano ;
            }
            else
            {
                throw new Exception("Meses RD = 0. \tMeses AU = 0. \tMeses simultáneos =0. \n\nAlguno de estos campos debe ser distinto de 0. \nSe requiere corregir este error antes de volver a realizar el cálculo.");

            }
        }

    }
}
