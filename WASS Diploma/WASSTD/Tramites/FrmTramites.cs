﻿using System;
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
        Controladora.cPersona cPersonas;
        Controladora.cCU_GestionarTramites cCU_GestionarTramites;


        FrmTramite FormTramite;
        BindingSource BsTramites;
        Modelo_Entidades.Usuario miUsuario;

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
            cPersonas = Controladora.cPersona.ObtenerInstancia();
            cTramite = Controladora.cTramite.ObtenerInstancia();
            cDetalles_Tramite = Controladora.cDetalles_Tramite.ObtenerInstancia();
            cCU_GestionarTramites = Controladora.cCU_GestionarTramites.ObtenerInstancia();
            miUsuario = oUsuario;

            //CU Gestionar Tramites: Paso 1
            botonera1.ArmaBotonera(cCU_GestionarTramites.ObtenerPermisos(miUsuario,"FrmTramites"));
                   
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
            BsTramites.DataSource = dgv_datos;
            List<Modelo_Entidades.Tramite> Tramites = cTramite.ObtenerTramites();
            List<Modelo_Entidades.Detalles_Tramite> Detalles_Tramites = cDetalles_Tramite.Obtener_Detalles_Tramites();
            List<Modelo_Entidades.Persona> Personas = cPersonas.ObtenerPersonas();
            
           

            //Conseguir ultimo detalle y ultima fecha de cada tramite en la lista
            foreach (Modelo_Entidades.Tramite t in Tramites)
            {
                //Obtengo la fecha del ultimo detalle de ese tramite
                DateTime ultimaFecha = cDetalles_Tramite.ObtenerUltimaFechaDetalle(t.Id);

                //Obtengo la descripción correspondiente a la ultima fecha
                foreach (Modelo_Entidades.Detalles_Tramite dt in Detalles_Tramites)
                {   
                    //Si la fecha del detalle es la ultima, me quedo con el dato descripcion y fecha
                    if (dt.fecha_desde == ultimaFecha)
                    {   
                        t.Ultima_Descripcion = dt.descripcion;
                        t.Ultima_Fecha = ultimaFecha;
                    }
                }
            }


            BsTramites.DataSource = Tramites;
            dgv_datos.DataSource = null;
            dgv_datos.DataSource = BsTramites.List;

            //DNI de la persona a la que le corresponde ese tramite
            int i = 0;
            foreach (DataGridViewRow fila in dgv_datos.Rows)
            {
                fila.Cells["dniColu"].Value = Tramites[i].Persona.dni.ToString();
                i++;
            }
            dgv_datos.Columns[0].HeaderText = "DNI";
            dgv_datos.Columns[0].DisplayIndex = 2;


            //Tipo de tramite (lo tengo que buscar a la fuerza)
            int j = 0;
            foreach (DataGridViewRow fila in dgv_datos.Rows)
            {
                fila.Cells["tipoTramiteCol"].Value = Tramites[j].Tipo_Tramite.descripcion.ToString(); //Busco la descripción a pulmon
                j++;
            }
            
            dgv_datos.Columns[1].Width = 200;

            // Ultima descripcion
            dgv_datos.Columns[2].HeaderText = "Descripción";
            dgv_datos.Columns[2].DisplayIndex = 4;
            dgv_datos.Columns[2].Width = 500;

            // Fecha Ultima modificacion
            dgv_datos.Columns[3].HeaderText = "Ultima modificación";
            dgv_datos.Columns[3].DisplayIndex = 5;

            // ID TRAMITE
            dgv_datos.Columns[4].HeaderText = "ID Trámite";
            dgv_datos.Columns[4].DisplayIndex = 0;
            dgv_datos.Columns[4].Width = 75;

            //ID Tipo de tramite                     (NO LO MUESTRO) no me muestra la descripcion, queda en blanco
            dgv_datos.Columns[5].HeaderText = "ID Tipo de Tramite ";
            dgv_datos.Columns[5].Visible = false;
            //dgv_datos.Columns[5].DataPropertyName = "descripcion";
            
            

            //Estado del tramite (NO LO MUESTRO) no me interesa
            dgv_datos.Columns[6].HeaderText = "Estado";
            dgv_datos.Columns[6].Visible = false;

            //Detalles del tramite (NO LO MUESTRO) no me sirve
            dgv_datos.Columns[7].HeaderText = "Detalles_Tramite";
            dgv_datos.Columns[7].Visible = false;

            // Nombre y Apellido
            dgv_datos.Columns[8].HeaderText = "Nombre y Apellido";
            dgv_datos.Columns[8].DisplayIndex = 3;
            dgv_datos.Columns[8].Width = 150;

            //TIPO DE TRAMITE (NO LO MUESTRO) no funciona
            dgv_datos.Columns[9].HeaderText = "Tipo de Tramite";
           // dgv_datos.Columns[9].DataPropertyName = "descripcion";
            dgv_datos.Columns[9].DisplayIndex = 1;
            dgv_datos.Columns[9].Width = 200;
            dgv_datos.Columns[9].Visible = false;
            
           

          


           /* //Muestro el DNI de la persona a la que le corresponde ese tramite
            int i = 0;
            foreach (DataGridViewRow fila in dgv_datos.Rows)
            {   
                fila.Cells["dniColu"].Value = Tramites[i].Persona.dni.ToString();
                i++;
            }
            //Acomodo las columnas de la grilla
            // ID
            dgv_datos.Columns[3].HeaderText = "ID";
            dgv_datos.Columns[3].DisplayIndex = 0;
            dgv_datos.Columns[3].Width = 75;
            

            // Tipo de Tramite
            dgv_datos.Columns[4].HeaderText = "Tipo de Tramite";
            dgv_datos.Columns[4].Width = 200;
            dgv_datos.Columns[4].DataPropertyName = "descripcion";
            dgv_datos.Columns[4].DisplayIndex = 1;

            dgv_datos.Columns[0].HeaderText = "DNI";
            dgv_datos.Columns[0].DisplayIndex = 2;
            
            // Nombre y Apellido
            dgv_datos.Columns[7].HeaderText = "Nombre y Apellido"; 
            dgv_datos.Columns[6].HeaderText = "Nombre y Apellido";
            dgv_datos.Columns[6].Visible = false;
            dgv_datos.Columns[7].DisplayIndex = 3;
            dgv_datos.Columns[7].Width = 150;

            // Ultima descripcion/detalle 
            dgv_datos.Columns[1].HeaderText = "Descripción";
            dgv_datos.Columns[1].DisplayIndex = 4;
            dgv_datos.Columns[1].Width = 925;

            // Fecha Ultimo Detalle
            dgv_datos.Columns[2].HeaderText= "Ultima modificación";
            dgv_datos.Columns[2].DisplayIndex = 5;

            // Oculto la del detalle que no me sirve (es la coleccio nde detalles del tramite
            dgv_datos.Columns[5].Visible = false;


            dgv_datos.Columns[8].HeaderText = "Tipo de Tramite";
            dgv_datos.Columns[8].DataPropertyName = "descripcion";

           */


           
        }

        // Al hacer click en "Agregar"
        private void botonera1_Click_Alta(object sender, EventArgs e)
        {
            FormTramite = new FrmTramite("Alta", new Modelo_Entidades.Tramite(), miUsuario);
            DialogResult dr = FormTramite.ShowDialog();
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

            FormTramite = new FrmTramite("Modifica", (Modelo_Entidades.Tramite)dgv_datos.CurrentRow.DataBoundItem, miUsuario);
            DialogResult dr = FormTramite.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Arma_Lista();
            }
        }

        // Al hacer click en "Ver Detalles"
        private void botonera1_Click_Consulta(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                return;
            }

            FormTramite = new FrmTramite("Consulta", (Modelo_Entidades.Tramite)dgv_datos.CurrentRow.DataBoundItem, miUsuario);
            DialogResult dr = FormTramite.ShowDialog();
        }

        
        // Al hacer click en "Eliminar"
        private void botonera1_Click_Baja(object sender, EventArgs e)
        {
            if (dgv_datos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un trámite para eliminar.");
                return;
            }

            try
            {
                DialogResult Rta1 = MessageBox.Show("El trámite posee muchos detalles. Se considera que no fue dado de alta por error. No es posible eliminarlo.", "Baja", MessageBoxButtons.OK);
                DialogResult Rta = MessageBox.Show("¿Confirma la eliminación del trámite seleccionado?", "Baja", MessageBoxButtons.YesNo);
                if (Rta == DialogResult.Yes)
                {

                    /////////////////////////////////////////////////////////////////////////////////////////////////////CODIFICAR ACA LA BAJA DEL Trámite
                    /*Modelo_Entidades.Grupo oGrup = (Modelo_Entidades.Grupo)dgv_datos.CurrentRow.DataBoundItem;
                    if (cGrupo.ValidarMiembrosGrupo(oGrup) == false)
                    {
                        MessageBox.Show("Para eliminar el grupo, primero debe desasociar a todos sus miembros y eliminar todos sus perfiles");
                        return;
                    }
                    cGrupo.EliminarGrupo(oGrup);
                    MessageBox.Show("El Grupo fue eliminado");
                    Arma_Lista(); */
                }

                else
                {
                    return;
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.InnerException.ToString());
            }
        }


        // Al cambiar texto en Nombre y apellido de la persona para filtrar
        private void txt_nya_Persona_TextChanged(object sender, EventArgs e)
        {
            BsTramites = new BindingSource();
            BsTramites.DataSource = dgv_datos;

            //Obtengo los tramites de la/s personas filtrando por el Nombre y Apellido ingresado
            List<Modelo_Entidades.Tramite> Tramites = cTramite.ObtenerTramitesPorNombeApellido(txt_nya_Persona.Text);
            List<Modelo_Entidades.Detalles_Tramite> Detalles_Tramites = cDetalles_Tramite.Obtener_Detalles_Tramites();
            List<Modelo_Entidades.Persona> Personas = cPersonas.ObtenerPersonas();


            //Conseguir ultimo detalle y ultima fecha de cada tramite en la lista
            foreach (Modelo_Entidades.Tramite t in Tramites)
            {
                //Obtengo la fecha del ultimo detalle de ese tramite
                DateTime ultimaFecha = cDetalles_Tramite.ObtenerUltimaFechaDetalle(t.Id);

                //Obtengo la descripción correspondiente a la ultima fecha
                foreach (Modelo_Entidades.Detalles_Tramite dt in Detalles_Tramites)
                {
                    //Si la fecha del detalle es la ultima, me quedo con el dato descripcion y fecha
                    if (dt.fecha_desde == ultimaFecha)
                    {
                        t.Ultima_Descripcion = dt.descripcion;
                        t.Ultima_Fecha = ultimaFecha;
                    }
                }
            }


            BsTramites.DataSource = Tramites;
            dgv_datos.DataSource = null;
            dgv_datos.DataSource = BsTramites.List;

            //Muestro el DNI de la persona a la que le corresponde ese tramite
            int i = 0;
            foreach (DataGridViewRow fila in dgv_datos.Rows)
            {
                fila.Cells["dniColu"].Value = Tramites[i].Persona.dni.ToString();
                i++;
            }
            //Acomodo las columnas de la grilla
            // ID
            dgv_datos.Columns[3].HeaderText = "ID";
            dgv_datos.Columns[3].DisplayIndex = 0;
            dgv_datos.Columns[3].Width = 75;


            // Tipo de Tramite
            dgv_datos.Columns[4].HeaderText = "Tipo de Tramite";
            dgv_datos.Columns[4].Width = 200;
            dgv_datos.Columns[4].DisplayIndex = 1;

            dgv_datos.Columns[0].HeaderText = "DNI";
            dgv_datos.Columns[0].DisplayIndex = 2;

            // Nombre y Apellido
            dgv_datos.Columns[6].HeaderText = "Nombre y Apellido";
            dgv_datos.Columns[6].DisplayIndex = 3;
            dgv_datos.Columns[6].Width = 150;

            // Ultima descripcion/detalle 
            dgv_datos.Columns[1].HeaderText = "Descripción";
            dgv_datos.Columns[1].DisplayIndex = 4;
            dgv_datos.Columns[1].Width = 925;

            // Fecha Ultimo Detalle
            dgv_datos.Columns[2].HeaderText = "Ultima modificación";
            dgv_datos.Columns[2].DisplayIndex = 5;

            // Oculto la del detalle que no me sirve (es la coleccio nde detalles del tramite
            dgv_datos.Columns[5].Visible = false;  

        }

        // Al cambiar el texto en DNI de la persona para Filtrar
        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            BsTramites = new BindingSource();
            BsTramites.DataSource = dgv_datos;

            //Obtengo los tramites de la/s personas filtrando por el DNI ingresado
            List<Modelo_Entidades.Tramite> Tramites = cTramite.ObtenerTramitesPorDNI(txt_dni.Text);
            List<Modelo_Entidades.Detalles_Tramite> Detalles_Tramites = cDetalles_Tramite.Obtener_Detalles_Tramites();
            List<Modelo_Entidades.Persona> Personas = cPersonas.ObtenerPersonas();


            //Conseguir ultimo detalle y ultima fecha de cada tramite en la lista
            foreach (Modelo_Entidades.Tramite t in Tramites)
            {
                //Obtengo la fecha del ultimo detalle de ese tramite
                DateTime ultimaFecha = cDetalles_Tramite.ObtenerUltimaFechaDetalle(t.Id);

                //Obtengo la descripción correspondiente a la ultima fecha
                foreach (Modelo_Entidades.Detalles_Tramite dt in Detalles_Tramites)
                {
                    //Si la fecha del detalle es la ultima, me quedo con el dato descripcion y fecha
                    if (dt.fecha_desde == ultimaFecha)
                    {
                        t.Ultima_Descripcion = dt.descripcion;
                        t.Ultima_Fecha = ultimaFecha;
                    }
                }
            }


            BsTramites.DataSource = Tramites;
            dgv_datos.DataSource = null;
            dgv_datos.DataSource = BsTramites.List;

            //Muestro el DNI de la persona a la que le corresponde ese tramite
            int i = 0;
            foreach (DataGridViewRow fila in dgv_datos.Rows)
            {
                fila.Cells["dniColu"].Value = Tramites[i].Persona.dni.ToString();
                i++;
            }
            //Acomodo las columnas de la grilla
            // ID
            dgv_datos.Columns[3].HeaderText = "ID";
            dgv_datos.Columns[3].DisplayIndex = 0;
            dgv_datos.Columns[3].Width = 75;


            // Tipo de Tramite
            dgv_datos.Columns[4].HeaderText = "Tipo de Tramite";
            dgv_datos.Columns[4].Width = 200;
            dgv_datos.Columns[4].DisplayIndex = 1;

            dgv_datos.Columns[0].HeaderText = "DNI";
            dgv_datos.Columns[0].DisplayIndex = 2;

            // Nombre y Apellido
            dgv_datos.Columns[6].HeaderText = "Nombre y Apellido";
            dgv_datos.Columns[6].DisplayIndex = 3;
            dgv_datos.Columns[6].Width = 150;

            // Ultima descripcion/detalle 
            dgv_datos.Columns[1].HeaderText = "Descripción";
            dgv_datos.Columns[1].DisplayIndex = 4;
            dgv_datos.Columns[1].Width = 925;

            // Fecha Ultimo Detalle
            dgv_datos.Columns[2].HeaderText = "Ultima modificación";
            dgv_datos.Columns[2].DisplayIndex = 5;

            // Oculto la del detalle que no me sirve (es la coleccio nde detalles del tramite
            dgv_datos.Columns[5].Visible = false;  
        }

        // Al cambiar el texto en Numero de tramite para Filtrar
        private void txt_NroDeTramite_TextChanged(object sender, EventArgs e)
        {
            BsTramites = new BindingSource();
            BsTramites.DataSource = dgv_datos;

            //Obtengo los tramites de la/s personas filtrando por el DNI ingresado
            List<Modelo_Entidades.Tramite> Tramites = cTramite.ObtenerTramitesPorNumeroID(txt_NroDeTramite.Text);
            List<Modelo_Entidades.Detalles_Tramite> Detalles_Tramites = cDetalles_Tramite.Obtener_Detalles_Tramites();
            List<Modelo_Entidades.Persona> Personas = cPersonas.ObtenerPersonas();


            //Conseguir ultimo detalle y ultima fecha de cada tramite en la lista
            foreach (Modelo_Entidades.Tramite t in Tramites)
            {
                //Obtengo la fecha del ultimo detalle de ese tramite
                DateTime ultimaFecha = cDetalles_Tramite.ObtenerUltimaFechaDetalle(t.Id);

                //Obtengo la descripción correspondiente a la ultima fecha
                foreach (Modelo_Entidades.Detalles_Tramite dt in Detalles_Tramites)
                {
                    //Si la fecha del detalle es la ultima, me quedo con el dato descripcion y fecha
                    if (dt.fecha_desde == ultimaFecha)
                    {
                        t.Ultima_Descripcion = dt.descripcion;
                        t.Ultima_Fecha = ultimaFecha;
                    }
                }
            }


            BsTramites.DataSource = Tramites;
            dgv_datos.DataSource = null;
            dgv_datos.DataSource = BsTramites.List;

            //Muestro el DNI de la persona a la que le corresponde ese tramite
            int i = 0;
            foreach (DataGridViewRow fila in dgv_datos.Rows)
            {
                fila.Cells["dniColu"].Value = Tramites[i].Persona.dni.ToString();
                i++;
            }
            //Acomodo las columnas de la grilla
            // ID
            dgv_datos.Columns[3].HeaderText = "ID";
            dgv_datos.Columns[3].DisplayIndex = 0;
            dgv_datos.Columns[3].Width = 75;


            // Tipo de Tramite
            dgv_datos.Columns[4].HeaderText = "Tipo de Tramite";
            dgv_datos.Columns[4].Width = 200;
            dgv_datos.Columns[4].DisplayIndex = 1;

            dgv_datos.Columns[0].HeaderText = "DNI";
            dgv_datos.Columns[0].DisplayIndex = 2;

            // Nombre y Apellido
            dgv_datos.Columns[6].HeaderText = "Nombre y Apellido";
            dgv_datos.Columns[6].DisplayIndex = 3;
            dgv_datos.Columns[6].Width = 150;

            // Ultima descripcion/detalle 
            dgv_datos.Columns[1].HeaderText = "Descripción";
            dgv_datos.Columns[1].DisplayIndex = 4;
            dgv_datos.Columns[1].Width = 925;

            // Fecha Ultimo Detalle
            dgv_datos.Columns[2].HeaderText = "Ultima modificación";
            dgv_datos.Columns[2].DisplayIndex = 5;

            // Oculto la del detalle que no me sirve (es la coleccio nde detalles del tramite
            dgv_datos.Columns[5].Visible = false;  
        }

        // Click en Mostrar todos
        private void btn_RecargarLista_Click(object sender, EventArgs e)
        {
            txt_dni.Text = "";
            txt_NroDeTramite.Text = "";
            txt_nya_Persona.Text = "";
            Arma_Lista();

        }

        // Al hacer click en "Cerrar"
        private void botonera1_Click_Cerrar(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
    }
}
