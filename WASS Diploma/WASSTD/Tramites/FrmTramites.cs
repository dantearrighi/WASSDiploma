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
            List<Modelo_Entidades.Tramite> Tramites = cTramite.ObtenerTramites();
            List<Modelo_Entidades.Detalles_Tramite> Detalles_Tramites = cDetalles_Tramite.Obtener_Detalles_Tramites();

            var Consulta = from Modelo_Entidades.Tramite t in Tramites
                           join Modelo_Entidades.Detalles_Tramite dt in Detalles_Tramites on t.Id equals dt.TramiteId
                           select new
                           {
                               ID = t.Id,
                               Tipo = t.tipo_tramite,
                               Documento = t.Persona.dni,
                               Persona = t.Persona.nombre_apellido,
                               Descripcion = (from udt in Detalles_Tramites
                                              where udt.fecha_desde == (from ddtt in Detalles_Tramites
                                                                        where t.Id == ddtt.TramiteId
                                                                        select ddtt.fecha_desde).Max()
                                              select udt.descripcion

                                               ).First(),
                               Fecha_Ultimo = (from ddttt in Detalles_Tramites
                                               where t.Id == ddttt.TramiteId
                                               select dt.fecha_desde).Max(),
                              
                           };
            // OTRA OPCION con GROUP BY

            /*
             * var Consulta = from Modelo_Entidades.Tramite t in Tramites
                           join Modelo_Entidades.Detalles_Tramite dt in Detalles_Tramites on t.Id equals dt.TramiteId
                           group t by new
                           {
                               ID = t.Id,
                               Fecha_Ultimo = (from ddttt in Detalles_Tramites
                                               where t.Id == ddttt.TramiteId
                                               select dt.fecha_desde),
                               Tipo = t.tipo_tramite,
                               Documento = t.Persona.dni,
                               Persona = t.Persona.nombre_apellido,
                               Descripcion = (from udt in Detalles_Tramites
                                              where udt.fecha_desde == (from ddtt in Detalles_Tramites
                                                                        where t.Id == ddtt.TramiteId
                                                                        select ddtt.fecha_desde).Max()
                                              select udt.descripcion

                                               ).First(),
                            
                           } into ListaTramites
                           select new {
                               IDTramite = ListaTramites.Key.ID,
                               TipoTramite=ListaTramites.Key.Tipo,
                               Documento = ListaTramites.Key.Documento,
                               Persona = ListaTramites.Key.Persona,
                               Descripcion = ListaTramites.Key.Descripcion,
                               FechaUltimoEstado= ListaTramites.Key.Fecha_Ultimo
                               
                               
                               
                           } ;
             * */














            BsTramites.DataSource = Consulta;

            dgv_datos.DataSource = null;
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
