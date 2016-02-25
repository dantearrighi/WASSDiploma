using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class cCU_RecuperarPerfilPorFormulario
    {
         // Declaración de variables a usar en la clase
        private static cCU_RecuperarPerfilPorFormulario instancia;
        Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
        

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
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }
        


        //Listar Permisos para un formulario de un usuario ----- equivalente a ArmaPerfil
        
        public List<Modelo_Entidades.Perfil> ObtenerPermisosPorFormulario (Modelo_Entidades.Usuario oUsuario, string nombreForm)
        {
            //Creo una lista de permisos
            List<Modelo_Entidades.Perfil> ListaPermisosFormulario = new List<Modelo_Entidades.Perfil>();
            
            try
            {   //Para cada uno de los grupos a los que pertenece el usuario
                foreach (Modelo_Entidades.Grupo oGrupo in oUsuario.Grupos)
                {   
                    //Y para cada uno de los perfiles (o acciones que puede ejecutar un grupo en un formulario) que hay en ese grupo
                    foreach (Modelo_Entidades.Perfil oPerfil in oGrupo.Perfiles)
                    {
                        if(oPerfil.Formulario.descripcion == nombreForm)
                        {
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

