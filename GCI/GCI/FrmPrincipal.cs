using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace GCI
{
    public partial class FrmPrincipal : Form
    {
        // Declaracion de varibles a utilizar en el formulario
        Modelo_Entidades.Usuario oUsuario;
        Modelo_Entidades.Auditoria_Log oAuditoria;
        Controladora.cModulo cModulo;
        Controladora.cPerfil cPerfil;
        Controladora.cUsuario cUsuario;
        Controladora.cAuditoria cAuditoria;

        // Declaro como privado al formulario
        private Form miFormulario;

        // Declaro como publico al constructor
        public FrmPrincipal()
        {
            InitializeComponent();

            // Instancio a las controladoras del modulo
            cModulo = Controladora.cModulo.ObtenerInstancia();
            cPerfil = Controladora.cPerfil.ObtenerInstancia();
            cUsuario = Controladora.cUsuario.ObtenerInstancia();
            cAuditoria = Controladora.cAuditoria.ObtenerInstancia();
        }

        // Cuando carga el formulario
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Lo primero que hago es crear un formulario de Login, así que instancio las variables
            FrmLogin FormularioLogin = new FrmLogin();
            DialogResult DrLogin = FormularioLogin.ShowDialog();

            // Despues pregunto si el formulario dio Ok. En caso de que no, salgo
            if (DrLogin != DialogResult.OK)
            {
                Application.Exit();
                return;
            }

            // Si dio Ok, creo el formulario de Login con el usuario.
            oUsuario = FormularioLogin.UsuarioLogin;
            oAuditoria = new Modelo_Entidades.Auditoria_Log();
            oAuditoria.usuario = oUsuario.nombre_apellido;
            oAuditoria.fecha = DateTime.Now;
            oAuditoria.accion = "Ingreso al Sistema";
            cAuditoria.AuditarLogUsuario(oAuditoria);
            // Además coloco el nombre y el apellido del usuario en la barra de estado
            toolStripStatusLabel1.Text = oUsuario.nombre_apellido;
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();

            ToolStripDropDownButton Menu_Cerrar;
            Menu_Cerrar = new ToolStripDropDownButton();
            Menu_Cerrar.Name = "Cerrar";
            Menu_Cerrar.Text = "Cerrar";
            msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_Cerrar });

            // Creo un submenú para salir
            ToolStripMenuItem SubMenu_Salir;
            SubMenu_Salir = new ToolStripMenuItem();
            SubMenu_Salir.Name = "Salir";
            SubMenu_Salir.Text = "Salir";
            SubMenu_Salir.Tag = "Salir";
            Menu_Cerrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { SubMenu_Salir });
            SubMenu_Salir.Click += new EventHandler(SubMenu_Salir_Click);

            //Creo un submenú para cambiar sesión
            ToolStripMenuItem SubMenu_CerrarSesion;
            SubMenu_CerrarSesion = new ToolStripMenuItem();
            SubMenu_CerrarSesion.Name = "Cerrar_Sesión";
            SubMenu_CerrarSesion.Text = "Cerrar Sesión";
            SubMenu_CerrarSesion.Tag = "Cerrar_Sesión";
            Menu_Cerrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { SubMenu_CerrarSesion });
            SubMenu_CerrarSesion.Click += new EventHandler(SubMenu_CerrarSesion_Click);

            //Creo un submenú para cambiar la clave
            ToolStripMenuItem SubMenu_CambiarClave;
            SubMenu_CambiarClave = new ToolStripMenuItem();
            SubMenu_CambiarClave.Name = "Cambiar_clave";
            SubMenu_CambiarClave.Text = "Cambiar clave";
            SubMenu_CambiarClave.Tag = "Cambiar_clave";
            Menu_Cerrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { SubMenu_CambiarClave });
            SubMenu_CambiarClave.Click += new EventHandler(SubMenu_CambiarClave_Click);


            // Creo un objeto DropDwnButton para cargar los módulos en la barra de menúes del formulario
            ToolStripDropDownButton Menu_Modulo;

            foreach (Modelo_Entidades.Grupo oGrupo in cUsuario.ObtenerGruposUsuario(oUsuario.id))
            {
                foreach (Modelo_Entidades.Modulo oModulo in cPerfil.ObtenerModulosPorGrupo(oGrupo.id))
                {
                    // Por cáda módulo creo un objeto ToolStripDropDownButton
                    Menu_Modulo = new ToolStripDropDownButton();
                    Menu_Modulo.Name = oModulo.descripcion.ToString();
                    Menu_Modulo.Text = oModulo.descripcion;

                    // Inserto el objeto creado a la barra de menúes del formulario
                    msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { Menu_Modulo });

                    // Busco las funciones asociadas al formulario
                    ArmaFormularios(oGrupo.id, Menu_Modulo, oModulo);
                }
            }
        }

        // Armo los menues y submenues
        private void ArmaFormularios(int grupo, ToolStripDropDownButton Menu_Modulos, Modelo_Entidades.Modulo oModulo)
        {
            // Le solicito a la controladora la lista de funciones de un módulo determinado.
            // Defino un objeto ToolStripMenuItem para asignar los permisos recuperados.
            ToolStripMenuItem SubMenu_Formularios;
                        
            // Recorro el listado de los permisos según el perfil

            foreach (Modelo_Entidades.Formulario oFormulario in cPerfil.ObtenerFormulariosPorModulo(oModulo))
                {
                    // Creo el objeto ToolStripMenuItem para cargar la funcion recibida
                    SubMenu_Formularios = new ToolStripMenuItem();
                    SubMenu_Formularios.Name = oFormulario.descripcion.ToString();
                    SubMenu_Formularios.Text = oFormulario.nombredemuestra;
                    SubMenu_Formularios.Tag = oFormulario.descripcion;

                    // Agrego la función al módulo asociado
                    Menu_Modulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { SubMenu_Formularios });

                    // Le asigno el método que tiene que ejecutar cuando se dispare el evento click de la función.
                    SubMenu_Formularios.Click += new EventHandler(this.ItemClick);
                }
        }

        void SubMenu_CerrarSesion_Click(object sender, EventArgs e)
        {
            oAuditoria = new Modelo_Entidades.Auditoria_Log();
            oAuditoria.usuario = oUsuario.nombre_apellido;
            oAuditoria.fecha = DateTime.Now;
            oAuditoria.accion = "Egreso del Sistema";
            cAuditoria.AuditarLogUsuario(oAuditoria);
            this.Hide();
            FrmPrincipal Form = new FrmPrincipal();
            Form.Show();
        }

        void SubMenu_CambiarClave_Click(object sender, EventArgs e)
        {
            FrmCambiarClave Form = new FrmCambiarClave(oUsuario);
            Form.Show();
        }

        void SubMenu_Salir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        // Establesco que pasa cuando hago un click en los menues y submenues
        private void ItemClick(object sender, EventArgs e)
        {
            // Al hacer click en algún objeto ToolStripMenuItem se dispara este evento.
            // El atributo sender me permite identificar que opción del menú generó el evento.
            ToolStripMenuItem seleccion = (ToolStripMenuItem)sender;
            // Si el atributo tag es distinto de 0 es porque tiene definido el nombre del formulario.
            if ((string)seleccion.Tag != "0")
            {
                // Le pido al compilador que me recupere todos los elementos del asembly (proyecto Vista)               
                // Comienzo a recorrer cada elemento devuelto
                foreach (System.Type type in Assembly.GetExecutingAssembly().GetTypes())
                {
                    // Pregunto si es de tipo Formulario
                    if (type.IsSubclassOf(typeof(Form)))
                    {
                        // Verifico si el nombre del formulario es igual al atributo tag que tiene el nombre del formulario al abrir
                        if (type.Name.ToString() == (string)seleccion.Tag)
                        {
                            try
                            {
                                // Si corresponde creo una instancia de ese objeto
                                Type t = type as Type;
                                // Aplicando reflection invoco el metodo getINSTANCIA del formulario
                                miFormulario = (Form)t.InvokeMember("ObtenerInstancia", BindingFlags.Default | BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.InvokeMethod, null, null, new object[] { this.oUsuario}) as System.Windows.Forms.Form;
                                // Ejecuto el método show del formulario para que lo muestre
                                miFormulario.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }

        // Cuando se cierra el formulario
        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            oAuditoria = new Modelo_Entidades.Auditoria_Log();
            if (oUsuario == null)
            {
                Application.Exit();
            }
            else
            {
                oAuditoria.usuario = oUsuario.nombre_apellido;
                oAuditoria.fecha = DateTime.Now;
                oAuditoria.accion = "Egreso del Sistema";
                cAuditoria.AuditarLogUsuario(oAuditoria);
                Application.Exit();
            }
        }
    }
}
