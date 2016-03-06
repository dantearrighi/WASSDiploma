using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Seguridad
{
    public class cCU_RecuperarPerfilPorFormulario
    {
        // Declaración de variables a usar en la clase
        private static cCU_RecuperarPerfilPorFormulario instancia;
        //Creo una lista de permisos que tiene el usuario sobre el formulario especificado
        private List<Modelo_Entidades.Perfil> ListaPermisosFormulario;


        //Aplico el patron de diseño Singleton para la clase cGrupo (cuando la solicitan desde otra)
        public static cCU_RecuperarPerfilPorFormulario ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_RecuperarPerfilPorFormulario();

            return instancia;

            
        }

        // Coloco al constructor como privado.
        private cCU_RecuperarPerfilPorFormulario()
        {
        ListaPermisosFormulario = new List<Modelo_Entidades.Perfil>();
        }

        
        //Listar Permisos para un formulario de un usuario ----- equivalente a ArmaPerfil
        public List<Modelo_Entidades.Perfil> ObtenerPermisosPorFormulario(Modelo_Entidades.Usuario oUsuario, string nombreForm)
        {
            
            //Limpio la lista por si tiene residuo
            ListaPermisosFormulario.Clear();

            try
            {   //Para cada uno de los grupos a los que pertenece el usuario
                foreach (Modelo_Entidades.Grupo oGrupo in oUsuario.Grupos)
                {
                    //Y para cada uno de los perfiles (o acciones que puede ejecutar un grupo en un formulario) que hay en ese grupo
                    foreach (Modelo_Entidades.Perfil oPerfil in oGrupo.Perfiles)
                    {
                        //Valido que corresponda al formulario sobre el cual solicito los permisos
                        if (oPerfil.Formulario.descripcion == nombreForm)
                        {
                            //Lo añado a la lista que sera devuelta
                            ListaPermisosFormulario.Add(oPerfil);
                        }
                    }
                }

                return ListaPermisosFormulario;
            }

            catch (Exception Exc)
            {
                throw new Exception(Exc.Message);
            }
        }


    }
}

