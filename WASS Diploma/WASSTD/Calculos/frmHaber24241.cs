using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WASSTD
{
    public partial class frmHaber24241 : Form
    {
        Controladora.Calculo.DatosCalculo oDatosCalculo = new Controladora.Calculo.DatosCalculo();
        Controladora.Calculo.Calculo oCalculo = new Controladora.Calculo.Calculo();

        public frmHaber24241()
        {
            InitializeComponent();
            oCalculo.SetCalculoStrategy(new Controladora.Calculo.Ley24241());
        }


        #region  // VARIABLES

       

        //PC
        decimal PCn;
        decimal PCm;
        decimal PCR;
        decimal PCp;
        decimal PCW;
        decimal PCN;
        decimal PC;

        //OTRAS
        decimal PBU;
        decimal SuplMov;
        decimal HT;

        //PAP
        decimal PAPn;
        decimal PAPm;
        decimal PAPR;
        decimal PAPp;
        decimal PAPW;
        decimal PAPN;
        decimal PAP;
         

        #endregion



        #region ////// METODOS

        //AGREGAR $
        private string AgregarSignoPeso(decimal numero, TextBox txt)
        {

            txt.Text = "$ " + numero.ToString();

            return txt.Text;
        }

        //INGRESAR DATO . , 
        private void IngresarDato(decimal var, TextBox txt)
        {
            ControlarTxtVacio(txt);

            if (txt.Text.Contains("$"))
            {
                txt.Text = txt.Text.Replace("$", "");
            }
            
                txt.Text = txt.Text.Replace(".", ",");
                var = Convert.ToDecimal(txt.Text);

                switch (txt.Name)
                {
                    case "N0":
                        PCN = var;
                        break;

                    case "n1":
                        PCn = var;
                        break;

                    case "W":
                        PCW = var;
                        break;

                    case "m":
                        PCm = var;
                        break;

                    case "R":
                        PCR = var;
                        break;

                    case "p":
                        PCp = var;
                        break;

                    case "NN":
                        PAPN = var;
                        break;

                    case "nn1":
                        PAPn = var;
                        break;

                    case "WW":
                        PAPW = var;
                        break;

                    case "mm":
                        PAPm = var;
                        break;

                    case "RR":
                        PAPR = var;
                        break;

                    case "pp":
                        PAPp = var;
                        break;

                    case "txtPBU":
                        PBU = var;
                        break;

                    case "txtSuplMov":
                        SuplMov = var;
                        break;

                    default:
                        break;

                }

            }
            


        /*
         * //INGRESAR DATO . , 
        private void IngresarDato(decimal var, TextBox txt)
        {
            ControlarTxtVacio(txt);

            if (txt.Text.Contains("$"))
            {
                txt.Text = txt.Text.Replace("$", "");
            }
            
                txt.Text = txt.Text.Replace(".", ",");
                var = Convert.ToDecimal(txt.Text);

                switch (txt.Name)
                {
                    case "N0":
                        oDatosCalculo.PCN = var;
                        break;

                    case "n1":
                        oDatosCalculo.PCn = var;
                        break;

                    case "W":
                        oDatosCalculo.PCW = var;
                        break;

                    case "m":
                        oDatosCalculo.PCm = var;
                        break;

                    case "R":
                        oDatosCalculo.PCR = var;
                        break;

                    case "p":
                        oDatosCalculo.PCp = var;
                        break;

                    case "NN":
                        oDatosCalculo.PAPN = var;
                        break;

                    case "nn1":
                        oDatosCalculo.PAPn = var;
                        break;

                    case "WW":
                        oDatosCalculo.PAPW = var;
                        break;

                    case "mm":
                        oDatosCalculo.PAPm = var;
                        break;

                    case "RR":
                        oDatosCalculo.PAPR = var;
                        break;

                    case "pp":
                        oDatosCalculo.PAPp = var;
                        break;

                    case "txtPBU":
                        oDatosCalculo.PBU = var;
                        break;

                    case "txtSuplMov":
                        oDatosCalculo.SuplMov = var;
                        break;

                    default:
                        break;

                }

            }
         * */

        
         
        //QUITAR $
        private string QuitarSignoPeso(string texto)
        {
            texto = texto.Replace("$", "");

            return texto;
        }

        //Calcular Prestación Compensatoria PC Y PAP
        private void CalcularPC()
        {
            RealizarCalculo();
            
           
        }

        private void RealizarCalculo()
        {
            //OBTENGO DATOS PARA EL CALCULO PC
            oDatosCalculo.PCn = Convert.ToDecimal(QuitarSignoPeso(n1.Text));
            oDatosCalculo.PCN = Convert.ToDecimal(QuitarSignoPeso(N0.Text));
            oDatosCalculo.PCp = Convert.ToDecimal(QuitarSignoPeso(p.Text));
            oDatosCalculo.PCW = Convert.ToDecimal(QuitarSignoPeso(W.Text));
            oDatosCalculo.PCm = Convert.ToDecimal(QuitarSignoPeso(m.Text));
            oDatosCalculo.PCR = Convert.ToDecimal(QuitarSignoPeso(R.Text));

            //OBTENGO DATOS PARA CALCULO DE PAP
            oDatosCalculo.PAPn = Convert.ToDecimal(QuitarSignoPeso(nn1.Text));
            oDatosCalculo.PAPN = Convert.ToDecimal(QuitarSignoPeso(NN.Text));
            oDatosCalculo.PAPp = Convert.ToDecimal(QuitarSignoPeso(pp.Text));
            oDatosCalculo.PAPW = Convert.ToDecimal(QuitarSignoPeso(WW.Text));
            oDatosCalculo.PAPm = Convert.ToDecimal(QuitarSignoPeso(mm.Text));
            oDatosCalculo.PAPR = Convert.ToDecimal(QuitarSignoPeso(RR.Text));

            oDatosCalculo.PBU = Convert.ToDecimal(QuitarSignoPeso(txtPBU.Text));

            //Realizo el Calculo (previamente establecido en Haber 24.241)
            oCalculo.Calcular(oDatosCalculo);

            txtPrestacionCompensatoria.Text = oDatosCalculo.txtPrestacionCompensatoria.ToString();
            txtPap.Text = oDatosCalculo.txtPap.ToString();
        }

        //Calcular Prestación Adicional por Permanencia
        private void CalcularPAP()
        {
            PAPn = Convert.ToDecimal(QuitarSignoPeso(nn1.Text));
            PAPN = Convert.ToDecimal(QuitarSignoPeso(NN.Text));
            PAPp = Convert.ToDecimal(QuitarSignoPeso(pp.Text));
            PAPW = Convert.ToDecimal(QuitarSignoPeso(WW.Text));
            PAPm = Convert.ToDecimal(QuitarSignoPeso(mm.Text));
            PAPR = Convert.ToDecimal(QuitarSignoPeso(RR.Text));

            if (PAPm != 0 || PAPn != 0 || PAPp != 0)
            {
                PAP = (Convert.ToDecimal(0.015) * PAPN) * (((PAPn + PAPp) * PAPW + (PAPm + PAPp) * PAPR) / (PAPn + PAPm + PAPp));


                PAP = Decimal.Round(PAP, 2);
                txtPap.Text = AgregarSignoPeso(PAP, txtPap);
            }
            else
            {
                MessageBox.Show("Meses RD = 0. \tMeses AU = 0. \tMeses simultáneos =0. \n\nAlguno de estos campos debe ser distinto de 0. \nSe requiere corregir este error antes de volver a realizar el cálculo.", "PAP - Error de cálculo: División por 0 (cero)", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        //Limpiar Campos
        public  void Limpiar(Control parent)
        {
            
            foreach (Control C in parent.Controls)
            {
                if (C is TextBox)
                {
                    if (C.Name == "txtPBU" || C.Name == "txtPap" || C.Name == "txtPrestacionCompensatoria" || C.Name == "txtSuplMov" || C.Name == "txtHaberTotal")
                    {
                        C.Text = "$ 0"; // Eliminar el texto del TextBox
                    }
                    else
                    {
                        C.Text = "";
                    }
                }
                if (C.Controls.Count > 0)
                {
                    Limpiar(C);
                }
            }
            
        }
        
        //Controlar txtVacio
        public void ControlarTxtVacio(TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.Text = "0";
            }
        }

        #endregion


        #region EVENTOS

        //CALCULAR PC
        private void btnPrestacionCompensatoria_Click(object sender, EventArgs e)
        {
          CalcularPC();
            
        }
             

        //CALCULAR PAP 
        private void btnCalcularPap_Click(object sender, EventArgs e)
        {
            CalcularPAP();
            
            
            
            
            /*
            
            
            WW.Text =  WW.Text.Replace(".", ",");
            RR.Text = RR.Text.Replace(".", ",");

            PCn = Convert.ToDecimal(nn1.Text);
            PCN= Convert.ToDecimal(NN.Text);
            PCp= Convert.ToDecimal(pp.Text);
            PCW= Convert.ToDecimal(WW.Text);
            PCm= Convert.ToDecimal(mm.Text);
            PCR= Convert.ToDecimal(RR.Text);


            PAP= (Convert.ToDecimal(0.015) * PCN) * (((PCn + PCp) * PCW + (PCm + PCp) * PCR) / (PCn + PCm + PCp));
            
            
            PAP= Decimal.Round(PAP, 2);
            txtPap.Text = "$ " + PAP.ToString();
            */ 
        }

      
        //LOAD
        private void frmHaber24241_Load(object sender, EventArgs e)
        {

        }

        //CERRAR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //LIMPIAR CAMPOS 
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            HT = 0;
            PBU = 0;
            SuplMov = 0;

            PCn =0;
            PCm = 0;
            PCR = 0;
            PCp = 0;
            PCW = 0;
            PCN = 0;
            PC = 0;

           

            //PAP
            PAPn = 0;
            PAPm = 0;
            PAPR = 0;
            PAPp = 0;
            PAPW = 0;
            PAPN = 0;
            PAP = 0;
            Limpiar(this);
        }

        //CALCULAR HABER TOTAL 
        private void btnCalcularHaberT_Click(object sender, EventArgs e)
        {


            HT = oDatosCalculo.PC + oDatosCalculo.PBU + SuplMov + oDatosCalculo.PAP;
            HT = Decimal.Round(HT, 2);

            txtHaberTotal.Text = HT.ToString();
        }

        // INGRESAR PBU 
        private void txtPBU_Leave(object sender, EventArgs e)
        {
            if(txtPBU.Text.Contains("$"))
            {
                txtPBU.Text = QuitarSignoPeso(txtPBU.Text);
                IngresarDato(PBU, txtPBU);
            }
            else{
                if (txtPBU.Text == "")
                {
                    txtPBU.Text = "$ 0";
                }
                else
                {
                    IngresarDato(PBU, txtPBU);
                    AgregarSignoPeso(PBU, txtPBU);
                }
          
                }
            if (txtPBU.Text.Contains("$"))
            {
            }
            else
            {
                IngresarDato(PBU, txtPBU);
                AgregarSignoPeso(PBU, txtPBU);
            }


          /*  txtPBU.Text = txtPBU.Text.Replace(".", ",");
            
            PBU = Convert.ToDecimal(txtPBU.Text);

            txtPBU.Text = "$ " + PBU.ToString();

            txtPBU.Text = txtPBU.Text.Replace(".", ",");
*/
        }


        //HABER TOTAL SIGNO $
        private void txtHaberTotal_TextChanged(object sender, EventArgs e)
        {
            AgregarSignoPeso(HT, txtHaberTotal);
        }


        //SuplMov
        private void txtSuplMov_Leave(object sender, EventArgs e)
        {
            if (txtSuplMov.Text.Contains("$"))
            {
                txtSuplMov.Text = QuitarSignoPeso(txtSuplMov.Text);
                IngresarDato(SuplMov, txtSuplMov);
            }
            else
            {
                if (txtSuplMov.Text == "")
                {
                    txtSuplMov.Text = "$ 0";
                }
                else
                {
                    IngresarDato(SuplMov, txtSuplMov);
                    AgregarSignoPeso(SuplMov, txtSuplMov);
                }

            }

            
            if (txtSuplMov.Text.Contains("$"))
            {
            }
            else
            {
                IngresarDato(SuplMov, txtSuplMov);
                AgregarSignoPeso(SuplMov, txtSuplMov);
            }
            
        }


        #region INGRESO DE DATOS PC

       

        //N0
        private void N0_Leave(object sender, EventArgs e)
        {
            IngresarDato(PCN,N0);
            

        }

        //R
        private void R_Leave(object sender, EventArgs e)
        {
            IngresarDato(PCR, R);
            R.Text = AgregarSignoPeso(PCR, R);
            RR.Text = R.Text;
            

           
        }

        //n1
        private void n1_Leave(object sender, EventArgs e)
        {
            IngresarDato(PCn, n1);
        }

        //W
        private void W_Leave(object sender, EventArgs e)
        {
            IngresarDato(PCW, W);
            AgregarSignoPeso(PCW, W);
            
                WW.Text = W.Text;
            
           
        }

        //m
        private void m_Leave(object sender, EventArgs e)
        {
            IngresarDato(PCm, m);
            
        }

        //p
        private void p_Leave(object sender, EventArgs e)
        {
            IngresarDato(PCp, p);
        }


        #endregion //END Ingreso de datos


        #region INGRESO DE DATOS PAP
        // NN
        private void NN_Leave(object sender, EventArgs e)
        {
            IngresarDato(PAPN, NN);
        }

        //nn
        private void nn1_Leave(object sender, EventArgs e)
        {
            IngresarDato(PAPn, nn1);
        }

        //WW
        private void WW_Leave(object sender, EventArgs e)
        {
            if (WW.Text.Contains("$"))
            {
            }
            else
            {
                IngresarDato(PAPW, WW);
                AgregarSignoPeso(PAPW, WW);
            }
        }

        //RR
        private void RR_Leave(object sender, EventArgs e)
        {
            if (RR.Text.Contains("$"))
            {
            }
            else
            {
                IngresarDato(PAPR, RR);
                AgregarSignoPeso(PAPR, RR);
            }
        }

        //pp
        private void pp_Leave(object sender, EventArgs e)
        {
            IngresarDato(PAPp, pp);
        }

        //mm
        private void mm_Leave(object sender, EventArgs e)
        {
            IngresarDato(PAPm, mm);
        }


        #endregion


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Enter:
                    SendKeys.Send("{TAB}");
                    break;






                default:

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        


        #endregion

        private void btnRealizarCalculo_Click(object sender, EventArgs e)
        {
            RealizarCalculo();
        }








    }
}
