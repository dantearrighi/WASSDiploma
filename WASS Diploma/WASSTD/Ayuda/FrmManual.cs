using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WASSTD
{
    public partial class FrmManual : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmManual instancia;
        Controladora.cVideo cVideo;
        BindingSource BsVideos;
        Modelo_Entidades.Usuario miUsuario;
        string video;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmManual ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmManual(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmManual(oUsuario);
            }

            return instancia;
        }

        // Establezco como privado al constructor
        private FrmManual(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            cVideo = Controladora.cVideo.ObtenerInstancia();
            miUsuario = oUsuario;
        }

        // Cuando carga el formulario
        private void FrmManual_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Armo la lista de la grilla de datos
        private void Arma_Lista()
        {
            // Instancio el binding source
            BsVideos = new BindingSource();
            //Luego lo lleno con los datos de la grilla
            BsVideos.DataSource = dgv_datos;

            // Limpio la grilla
            dgv_datos.DataSource = null;
            // LLeno el binding con los datos que traigo de las entidades
            BsVideos.DataSource = cVideo.ObtenerVideoes();
            // Asigno el binding a la grilla
            dgv_datos.DataSource = BsVideos;
            dgv_datos.Columns[0].Visible = false;
            dgv_datos.Columns[1].HeaderText = "Descripción";
        }

        // Cuando le doy click a "Ver video"
        private void btn_link_Click(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                return;
            }

            video = ((Modelo_Entidades.Video)dgv_datos.CurrentRow.DataBoundItem).link;
            Process.Start(video);
        }

        // Al cambiar el texto en la descripción
        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            BsVideos.DataSource = cVideo.FiltrarPorDesc(txt_nombre.Text);
            dgv_datos.DataSource = BsVideos;
        }        
    }
}
