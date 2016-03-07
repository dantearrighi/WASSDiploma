using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Seguridad
{
    public class cCU_GestionarUsuarios
    {
        // Declaro las variables a utilizar en la clase
        private static cCU_GestionarUsuarios instancia;

        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
        cCU_AltaUsuario cCU_AltaUsuario;
        cCU_ModificarUsuario cCU_ModificarUsuario;
       
        
        

        // Aplico el patrón de diseño Singleton a la clase
        public static cCU_GestionarUsuarios ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_GestionarUsuarios();

            return instancia;
        }
        // Coloco al constructor como privado.
        private cCU_GestionarUsuarios()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
            cCU_AltaUsuario = Controladora.Seguridad.cCU_AltaUsuario.ObtenerInstancia();
            cCU_ModificarUsuario = Controladora.Seguridad.cCU_ModificarUsuario.ObtenerInstancia();
            
        }

        #region Obtener Usuario/S

        //Obtener un usuario
        public Modelo_Entidades.Usuario ObtenerUsuario(string userName)
        {    // Aca instancio un objeto "Usuario" y tomo el objeto "Entidades" que instancie en un principio.
            // Luego, a esas "Entidades", les pido que me traigan a todos los "Usuarios" en forma de Lista.
            // A esa Lista de "Usuarios" le pido que me encuentre y que me devuelva el usuario cuyo nombre es "usuario" que pasé por parámetros. 
            Modelo_Entidades.Usuario oUsuario = oModelo_Entidades.Usuarios.ToList().Find(delegate(Modelo_Entidades.Usuario fUsuario)
            {
                return fUsuario.usuario == userName;
            });

            return oUsuario;
        }

        //Obtener  todos los usuarios
        public List<Modelo_Entidades.Usuario> ObtenerUsuarios()
        {
            return oModelo_Entidades.Usuarios.ToList();
        }
        
        // Busco los usuarios por una descripción parcial
        public List<Modelo_Entidades.Usuario> BuscarUsuarios(string texto)
        {
            var Consulta = from oUsuario in oModelo_Entidades.Usuarios.ToList()
                           where oUsuario.nombre_apellido.ToLower().Contains(texto.ToLower())
                           select oUsuario;
            return (List<Modelo_Entidades.Usuario>)Consulta.ToList();
        }

        // Metodo de validación general para todos los usuarios - Los busca segun estado y grupo al que pertenecen 
        public List<Modelo_Entidades.Usuario> FiltrarUsuarios(string nya, string grupo, string estado)
        {
            var Consulta = from oUsuario in oModelo_Entidades.Usuarios.ToList()
                           select oUsuario;

            if (nya != "0")
            {                                                                   // aca iba containts
                Consulta = Consulta.Where(oUsuario => oUsuario.nombre_apellido.Contains(nya));
            }

            if (grupo != "0")
            {
                Consulta = Consulta.Where(oUsuario => oUsuario.Grupos.Contains(this.BuscoGrupo(grupo)));
            }

            if (estado == "0")
            {
                Consulta = Consulta.Where(oUsuario => oUsuario.estado == false);
            }

            if (estado == "1")
            {
                Consulta = Consulta.Where(oUsuario => oUsuario.estado == true);
            }

            return (List<Modelo_Entidades.Usuario>)Consulta.ToList();
        }
        // Método interno para buscar un grupo
        private Modelo_Entidades.Grupo BuscoGrupo(string grupo)
        {
            Modelo_Entidades.Grupo oGrupo = oModelo_Entidades.Grupos.ToList().Find(delegate(Modelo_Entidades.Grupo fGrupo)
            {
                return fGrupo.descripcion == grupo;
            });

            return oGrupo;
        }



        #endregion

        #region ABM Usuario
        // Alta de usuario
        public void AltaUsuario(Modelo_Entidades.Usuario oUsuario)
        {
            cCU_AltaUsuario.Alta(oUsuario);

        }


        // Modificar a un usuario
        public void Modificacion(Modelo_Entidades.Usuario oUsuario)
        {
            cCU_ModificarUsuario.Modificacion(oUsuario);

            
        }

        #endregion

        // Valido que no exista un usuario dado el nombre del usuario
        public Boolean ValidarNombreUsuario(string usuario)
        {
            Modelo_Entidades.Usuario oUsuario = oModelo_Entidades.Usuarios.ToList().Find(delegate(Modelo_Entidades.Usuario fUsuario)
            {
                return fUsuario.usuario == usuario;
            });

            if (oUsuario == null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
     

    
    }
}
