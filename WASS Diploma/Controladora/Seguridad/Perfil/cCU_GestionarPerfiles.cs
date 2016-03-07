using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora.Seguridad
{
    public class cCU_GestionarPerfiles
    {

        #region Variables, Metodos de clase y Constructor 

        // Declaración de variables a usar en la clase
        private static cCU_GestionarPerfiles instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
        private cCU_GestionarGrupos cCU_GestionarGrupos;
        private cCU_AltaPerfil _cCU_AltaPerfil;
        private cCU_ModificarPerfil _cCU_ModificaPerfil;
       
        


        //Aplico el patron de diseño Singleton para la clase controladora del CU Gestionar PERFILES (cuando la solicitan desde otra)
        public static cCU_GestionarPerfiles ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_GestionarPerfiles();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_GestionarPerfiles()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
            cCU_GestionarGrupos = Controladora.Seguridad.cCU_GestionarGrupos.ObtenerInstancia();
            _cCU_AltaPerfil = Controladora.Seguridad.cCU_AltaPerfil.ObtenerInstancia();
            _cCU_ModificaPerfil = Controladora.Seguridad.cCU_ModificarPerfil.ObtenerInstancia();
            
        }

        #endregion

        #region Obtener Perfiles

        // Obtengo los perfiles
        public List<Modelo_Entidades.Perfil> ObtenerPerfiles()
        {
            return oModelo_Entidades.Perfiles.ToList();
        }


        // Metodo de validación general para todos los perfiles
        public List<Modelo_Entidades.Perfil> FiltrarPerfiles(string grupo, string formulario, string permiso)
        {
            var Consulta = from oPerfil in oModelo_Entidades.Perfiles.ToList()
                           select oPerfil;

            if (grupo != "0")
            {
                Consulta = Consulta.Where(oPerfil => oPerfil.Grupo.descripcion == grupo);
            }

            if (formulario != "0")
            {
                Consulta = Consulta.Where(oPerfil => oPerfil.Formulario.nombredemuestra == formulario);
            }

            if (permiso != "0")
            {
                Consulta = Consulta.Where(oPerfil => oPerfil.Permiso.descripcion == permiso);
            }

            return (List<Modelo_Entidades.Perfil>)Consulta.ToList();
        }

        #endregion

        
        #region ALTA BAJA Y MODIFICACION PERFILES

        //Agrego un perfil
        public void AltaPerfil(Modelo_Entidades.Perfil oPerfil)
        {
            if (ValidarPerfil(oPerfil.Grupo, oPerfil.Formulario, oPerfil.Permiso))
            {
                _cCU_AltaPerfil.AltaPerfil(oPerfil);
            }
            else
            {
                throw new Exception("El perfil ya existe, ingrese otros parámetros");
            }
        }

        //Modifico a un perfil
        public void ModificarPerfil(Modelo_Entidades.Perfil oPerfil, Modelo_Entidades.Perfil PerfilModificado)
        {
            if (ValidarPerfil(PerfilModificado.Grupo, PerfilModificado.Formulario, PerfilModificado.Permiso))
            {
                oPerfil.Grupo = PerfilModificado.Grupo;
                oPerfil.Formulario = PerfilModificado.Formulario;
                oPerfil.Permiso = PerfilModificado.Permiso;

                _cCU_ModificaPerfil.ModificarPerfil(oPerfil);
            }
            else
            {
                throw new Exception("El perfil ya existe, ingrese otros parámetros");
            }
        }
          
        
        // Elimino un perfil
        public void BajaPerfil(Modelo_Entidades.Perfil oPerfil)
        {
            oModelo_Entidades.Perfiles.DeleteObject(oPerfil);
            oModelo_Entidades.SaveChanges();
        }




        #endregion


        #region VALIDACIONES PERFIL

        //Esta validacion corresponde al CU Alta Perfil y al CU Modificar Perfil
        // Valido que no exista un perfil dado el grupo, formulario y permiso
        public Boolean ValidarPerfil(Modelo_Entidades.Grupo oGrupo, Modelo_Entidades.Formulario oFormulario, Modelo_Entidades.Permiso oPermiso)
        {

            Modelo_Entidades.Perfil oPerfilExistente = oModelo_Entidades.Perfiles.ToList().FirstOrDefault(x=> (x.Grupo==oGrupo && x.Formulario==oFormulario && x.Permiso == oPermiso));
         /*   Modelo_Entidades.Perfil oPerfil = oModelo_Entidades.Perfiles.ToList().FirstOrDefault(delegate(Modelo_Entidades.Perfil fPerfil)
            {
                return (fPerfil.Grupo == oGrupo && fPerfil.Formulario == oFormulario && fPerfil.Permiso == oPermiso);
            });*/

            if (oPerfilExistente == null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        


        #endregion

        //CU RECUPERAR PERFIL POR FORMULARIO
       /* public List<String> RecuperarPerfilPorFormulario(Modelo_Entidades.Usuario oUsuario, string form)
        {
            
            List<String> AccionesHabilitadas = new List<String>();
            String accion;
          

            try
            {
                foreach (Modelo_Entidades.Grupo oGrupo in cCU_GestionarGrupos.ObtenerGruposUsuario(oUsuario.id))
                {
                    foreach (Modelo_Entidades.Permiso oPermiso in ObtenerPermisos(oGrupo.id, form))
                    {
                        switch (oPermiso.descripcion)
                        {
                            case "Alta":
                                accion ="Alta";
                                AccionesHabilitadas.Add(accion);
                                break;

                            case "Baja":
                                accion = "Baja";
                                AccionesHabilitadas.Add(accion);
                                break;

                            case "Modifica":
                                accion = "Modifica";
                                AccionesHabilitadas.Add(accion);
                                break;

                            case "Consulta":
                                accion = "Consulta";
                                AccionesHabilitadas.Add(accion);
                                break;
                        }
                    }
                }
                return AccionesHabilitadas;
            }

            catch (Exception Exc)
            {
                throw new Exception(Exc.Message);
            }
        }
        */


        // Obtengo los permisos según el grupo del usuario y el formulario seleccionado
        public List<Modelo_Entidades.Permiso> ObtenerPermisos(int grupo, string formulario)
        {
            var Consulta = from oPerfil in oModelo_Entidades.Perfiles.ToList()
                           where oPerfil.Grupo.id == grupo && oPerfil.Formulario.descripcion == formulario
                           select oPerfil.Permiso;
            return (List<Modelo_Entidades.Permiso>)Consulta.ToList();
        }

    }
}
