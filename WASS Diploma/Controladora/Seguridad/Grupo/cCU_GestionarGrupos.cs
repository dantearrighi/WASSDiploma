using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Seguridad
{
    public class cCU_GestionarGrupos
    {
        // Declaración de variables a usar en la clase
        private static cCU_GestionarGrupos instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
        private Controladora.Seguridad.cCU_AltaGrupo _cCU_AltaGrupo;
        private Controladora.Seguridad.cCU_ModificarGrupo _cCU_ModificarGrupo;
        private Controladora.Seguridad.cCU_BajaGrupo _cCU_BajaGrupo;
        private Controladora.Seguridad.cCU_RecuperarPerfilPorFormulario cCU_RecuperarPerfilPorFormulario;


        //Aplico el patron de diseño Singleton para la clase controladora del CU Gestionar GRUPOS (cuando la solicitan desde otra)
        public static cCU_GestionarGrupos ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_GestionarGrupos();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_GestionarGrupos()
        {
             oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
            _cCU_AltaGrupo =  cCU_AltaGrupo.ObtenerInstancia();
            _cCU_ModificarGrupo = cCU_ModificarGrupo.ObtenerInstancia();
            _cCU_BajaGrupo = cCU_BajaGrupo.ObtenerInstancia();
            cCU_RecuperarPerfilPorFormulario = Controladora.Seguridad.cCU_RecuperarPerfilPorFormulario.ObtenerInstancia();
        }

        //Obtener permisos de un usuario sobre un formulario
        public List<Modelo_Entidades.Perfil> ObtenerPermisos(Modelo_Entidades.Usuario oUsuario, string nombreForm)
        {
            //Invoco al caso de uso que devuelve los permisos que tiene un usuario sobre el formulario solicitado
            return cCU_RecuperarPerfilPorFormulario.ObtenerPermisosPorFormulario(oUsuario, nombreForm);
        }

        #region Obtener Grupos

        // Obtengo los grupos de un usuario
        public List<Modelo_Entidades.Grupo> ObtenerGruposUsuario(int id)
        {
            // Aca instancio un objeto "Usuario" y tomo el objeto "Entidades" que instancie en un principio.
            // Luego, a esas "Entidades", les pido que me traigan a todos los "Usuarios" en forma de Lista.
            // A esa Lista de "Usuarios" le pido que me encuentre y que me devuelva los grupos del usuario "usuario" que pasé por parámetros. 
            Modelo_Entidades.Usuario oUsuario = oModelo_Entidades.Usuarios.ToList().Find(delegate(Modelo_Entidades.Usuario fUsuario)
            {
                return fUsuario.id == id;
            });
            return oUsuario.Grupos.ToList();
        }


        // Obtengo los módulos según el grupo del usuario
        public List<Modelo_Entidades.Modulo> ObtenerModulosPorGrupo(int grupo)
        {
            var Consulta = from oPerfil in oModelo_Entidades.Perfiles.ToList()
                           where oPerfil.Grupo.id == grupo
                           group oPerfil by oPerfil.Formulario.Modulo into Modulos
                           select Modulos.Key;
            return (List<Modelo_Entidades.Modulo>)Consulta.ToList();
        }

        // Obtengo los grupos
        public List<Modelo_Entidades.Grupo> ObtenerGrupos()
        {
            return oModelo_Entidades.Grupos.ToList();
        }

       


        // Busco los grupos por una descripción parcial
        public List<Modelo_Entidades.Grupo> FiltrarGrupos(string texto)
        {
            var Consulta = from oGrupo in oModelo_Entidades.Grupos.ToList()
                           where oGrupo.descripcion.Contains(texto)
                           select oGrupo;
            return (List<Modelo_Entidades.Grupo>)Consulta.ToList();
        }



#endregion


        #region ABM Grupos

        // Agrego un grupo
        public void AltaGrupo(Modelo_Entidades.Grupo oGrupo)
        {
            _cCU_AltaGrupo.AltaGrupo(oGrupo);
           
        }

        // Modifico un grupo
        public void ModificarGrupo(Modelo_Entidades.Grupo oGrupo)
        {
            _cCU_ModificarGrupo.ModificarGrupo(oGrupo);
        }


        // Elimino a un grupo
        public void EliminarGrupo(Modelo_Entidades.Grupo oGrupo)
        {
            _cCU_BajaGrupo.EliminarGrupo(oGrupo);
        }

        #endregion


        #region Validaciones Grupo

        // Valido que no un grupo no tengo miembros asociados
        public Boolean ValidarMiembrosGrupo(Modelo_Entidades.Grupo oGrup)
        {
            Modelo_Entidades.Grupo oGrupo = oModelo_Entidades.Grupos.ToList().Find(delegate(Modelo_Entidades.Grupo fGrupo)
            {
                return fGrupo == oGrup;
            });

            if (oGrupo.Usuarios.Count == 0 && oGrupo.Perfiles.Count == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // Valido que no exista un grupo dado el nombre del grupo
        public Boolean ValidarGrupo(string grupo)
        {
            Modelo_Entidades.Grupo oGrupo = oModelo_Entidades.Grupos.ToList().Find(delegate(Modelo_Entidades.Grupo fGrupo)
            {
                return fGrupo.descripcion == grupo;
            });

            if (oGrupo == null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        #endregion


    }
}
