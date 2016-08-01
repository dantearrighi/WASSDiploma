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
    public partial class frmCalculos : Form
    {
        public frmCalculos()
        {
            InitializeComponent();
        }

        private void btnHaber24241_Click(object sender, EventArgs e)
        {
            frmHaber24241 formHaber24241 = new frmHaber24241();
            formHaber24241.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVetMalvina_Click(object sender, EventArgs e)
        {
            frmVetMalvinas formCalculo = new frmVetMalvinas();
            formCalculo.ShowDialog();
        }
    }
}
