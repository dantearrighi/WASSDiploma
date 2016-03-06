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

#endregion



    }
}
