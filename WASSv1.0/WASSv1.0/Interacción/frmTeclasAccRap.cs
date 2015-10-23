using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WASSv1._0.Interacción
{
    public partial class frmTeclasAccRap : Form
    {
        public frmTeclasAccRap()
        {
            InitializeComponent();
        }

           //TECLAS ACCESO RAPIDO
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                
                

                case Keys.Escape:
                    this.Close();
                    break;

                

                    
                default:

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
    }
}
