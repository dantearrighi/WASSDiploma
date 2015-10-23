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
    public partial class FrmComitentes : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmComitentes instancia;
        Controladora.cComitente cComitente;
        FrmComitente FormComitente;
        BindingSource BsComitentes;

        Modelo_Entidades.Comitente oComitente;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmComitentes ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmComitentes(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmComitentes(oUsuario);
            }

            return instancia;
        }

        // Declaro al constructor como privado
        private FrmComitentes(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            cComitente = Controladora.cComitente.ObtenerInstancia();
            botonera1.ArmaPerfil(oUsuario, "FrmComitentes");
        }

        // Cuando carga el formulario
        private void FrmComitentes_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Armo la lista de la grilla de datos
        private void Arma_Lista()
        {
            BsComitentes = new BindingSource();

            // Limpio la grilla
            dgv_datos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsComitentes.DataSource = cComitente.ObtenerComitentes().OrderBy(x=> x.razon_social).ToList();
            // Asigno el binding a la grilla
            dgv_datos.DataSource = BsComitentes;
            // Edito las columnas de la grilla
            dgv_datos.Columns[0].HeaderText = "Identificador";
            dgv_datos.Columns[1].HeaderText = "Razón Social";
        }

        // Al hacer click en "Agregar"
        private void botonera1_Click_Alta(object sender, EventArgs e)
        {
            FormComitente = new  FrmComitente("Alta", new Modelo_Entidades.Comitente());
            DialogResult dr = FormComitente.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Arma_Lista();
            }
        }

        // Al hacer click en "Eliminar"
        private void botonera1_Click_Baja(object sender, EventArgs e)
        {
            oComitente = (Modelo_Entidades.Comitente)dgv_datos.CurrentRow.DataBoundItem;
            try
            {
                DialogResult Rta = MessageBox.Show("¿Confirma la eliminación del comitente?", "Baja", MessageBoxButtons.YesNo);
                if (Rta == DialogResult.Yes)
                {
                    if (oComitente.Expedientes.Count != 0)
                    {
                        MessageBox.Show("No se puede eliminar el comitente debido a que existen expedientes vinculados a él");
                        return;
                    }

                    else
                    {
                        cComitente.EliminarComitente(oComitente);
                        MessageBox.Show("El comitente fue eliminado");
                        Arma_Lista();
                    }
                }

                else
                {
                    return;
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message.ToString());
            }
        }

        // Al hacer click en "Cerrar"
        private void botonera1_Click_Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        // Al hacer click en "Ver detalles"
        private void botonera1_Click_Consulta(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                return;
            }

            FormComitente = new FrmComitente("Consulta", (Modelo_Entidades.Comitente)dgv_datos.CurrentRow.DataBoundItem);
            DialogResult dr = FormComitente.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Arma_Lista();
            }
        }

        // Al hacer click en "Modificar"
        private void botonera1_Click_Modificacion(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                return;
            }

            FormComitente = new FrmComitente("Modifica", (Modelo_Entidades.Comitente)dgv_datos.CurrentRow.DataBoundItem);
            DialogResult dr = FormComitente.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Arma_Lista();
            }
        }

        // Al hacer click en el botón filtrar
        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            BsComitentes.DataSource = cComitente.FiltrarPorNyA(txt_comitente.Text);
            dgv_datos.DataSource = BsComitentes;
            // Edito las columnas de la grilla
            dgv_datos.Columns[0].HeaderText = "Identificador";
            dgv_datos.Columns[1].HeaderText = "Razón Social";
        }

        private void btn_nuevaconsulta_Click(object sender, EventArgs e)
        {
            Arma_Lista();
        }
    }
}
