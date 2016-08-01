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
    public partial class frmVetMalvinas : Form
    {
        public frmVetMalvinas()
        {
            InitializeComponent();
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
            
         
        //QUITAR $
        private string QuitarSignoPeso(string texto)
        {
            texto = texto.Replace("$", "");

            return texto;
        }

        //Calcular Prestación Compensatoria
        private void CalcularPC()
        {
            PCn = Convert.ToDecimal(QuitarSignoPeso(n1.Text));
            PCN = Convert.ToDecimal(QuitarSignoPeso(N0.Text));
            PCp = Convert.ToDecimal(QuitarSignoPeso(p.Text));
            PCW = Convert.ToDecimal(QuitarSignoPeso(W.Text));
            PCm = Convert.ToDecimal(QuitarSignoPeso(m.Text));
            PCR = Convert.ToDecimal(QuitarSignoPeso(R.Text));

            if (PCm != 0 || PCn != 0 || PCp != 0)
            {
                PC = (Convert.ToDecimal(0.015) * PCN) * (((PCn + PCp) * PCW + (PCm + PCp) * PCR) / (PCn + PCm + PCp));


                PC = Decimal.Round(PC, 2);
                txtPrestacionCompensatoria.Text = "$ " + PC.ToString();
            }
            else
            {
                MessageBox.Show("Meses RD = 0. \tMeses AU = 0. \tMeses simultáneos =0. \n\nAlguno de estos campos debe ser distinto de 0. \nSe requiere corregir este error antes de volver a realizar el cálculo.", "PC - Error de cálculo: División por 0 (cero)", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
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

           

            Limpiar(this);
        }

        //CALCULAR HABER TOTAL 
        private void btnCalcularHaberT_Click(object sender, EventArgs e)
        {
         
           
            HT = PC + 2500;
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








    }
}
