using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Controladora.Seguridad
{
    public class cCU_RecuperarPerfilPorFormulario
    {
        // Declaración de variables a usar en la clase
        private static cCU_RecuperarPerfilPorFormulario instancia;
        //Creo una lista de permisos que tiene el usuario sobre el formulario especificado
        private List<Perfiles> ListaPermisosFormulario = new List<Perfiles>();


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
         
        }

        
        //Listar Permisos para un formulario de un usuario ----- equivalente a ArmaPerfil
        public List<Perfiles> ObtenerPermisosPorFormulario(Usuarios oUsuario, string nombreForm)
        {
            
            //Limpio la lista por si tiene residuo
            ListaPermisosFormulario.Clear();

            try
            {   //Para cada uno de los grupos a los que pertenece el usuario
                foreach (Grupos oGrupo in oUsuario.Grupos)
                {
                    //Y para cada uno de los perfiles (o acciones que puede ejecutar un grupo en un formulario) que hay en ese grupo
                    foreach (Perfiles oPerfil in oGrupo.Perfiles)
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

