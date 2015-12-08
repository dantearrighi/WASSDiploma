using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WASSTD.Tramites
{
    public partial class FrmTramites : Form
    {
        // Declaro las variables que voy a utilizar en el formulario
        private static FrmTramites instancia;
        Controladora.cUsuario cUsuario;
        Controladora.cGrupo cGrupo;
        Controladora.cTramite cTramite;
        Controladora.cDetalles_Tramite cDetalles_Tramite;
        FrmTramite FormTramite;
        BindingSource BsTramites;
        BindingSource BsDetalles_Tramites;

        // Declaro al formulario como público y le asigno el método "Obtener Instancia" para poder llamarlo desde el formulario principal
        public static FrmTramites ObtenerInstancia(Modelo_Entidades.Usuario oUsuario)
        {
            if (instancia == null)
            {
                instancia = new FrmTramites(oUsuario);
            }

            if (instancia.IsDisposed)
            {
                instancia = new FrmTramites(oUsuario);
            }

            return instancia;
        }

        // Establezco como privado al constructor
        private FrmTramites(Modelo_Entidades.Usuario oUsuario)
        {
            InitializeComponent();
            cUsuario = Controladora.cUsuario.ObtenerInstancia();
            cGrupo = Controladora.cGrupo.ObtenerInstancia();
            cTramite = Controladora.cTramite.ObtenerInstancia();
            cDetalles_Tramite = Controladora.cDetalles_Tramite.ObtenerInstancia();
            botonera1.ArmaPerfil(oUsuario, "FrmTramites");
        }

        //Cuando cargo el formulario
        private void FrmTramites_Load(object sender, EventArgs e)
        {
            Arma_Lista();
        }

        // Armo la lista de la grilla de datos
        private void Arma_Lista()
        {
            BsTramites = new BindingSource();
            BsDetalles_Tramites = new BindingSource();
            BsTramites.DataSource = dgv_datos;


            dgv_datos.DataSource = null;
            BsTramites.DataSource = cTramite.ObtenerTramites();
           /* //BsDetalles_Tramites.DataSource = cDetalles_Tramite.BuscarUltimoDetalle();
            //  BsTramites.Add(BsDetalles_Tramites);
            

            foreach(Modelo_Entidades.Tramite tram in BsTramites.List)
            {
                BsTramites.Add(cDetalles_Tramite.BuscarUltimoDetalle(tram));
            }
            */
            dgv_datos.DataSource = BsTramites;

            /*  dgv_datos.Columns[0].Visible = false;
               dgv_datos.Columns[1].HeaderText = "Nombre y Apellido";
               dgv_datos.Columns[2].Visible = false;
               dgv_datos.Columns[3].HeaderText = "E-Mail";
               dgv_datos.Columns[4].HeaderText = "Estado";
               dgv_datos.Columns[5].HeaderText = "Nombre de Usuario";
               dgv_datos.Columns[6].Visible= false;*/
        }


    }
}
