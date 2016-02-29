using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Controladora
{
    public class cPerfil
    {
        // Declaración de variables a usar en la clase
        private static cPerfil instancia;
        //private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        //Aplico el patron de diseño Singleton para la clase cPerfil (cuando la solicitan desde otra)
        public static cPerfil ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cPerfil();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cPerfil()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

        // Obtengo los módulos según el grupo del usuario
        public List<Modulos> ObtenerModulosPorGrupo(int grupo)
        {
            var Consulta = from oPerfil in oPerfiles.ToList()
                           where oPerfil.Grupo.id == grupo 
                           group oPerfil by oPerfil.Formulario.Modulo into Modulos
                           select Modulos.Key;
            return (List<Modulos>)Consulta.ToList();
        }

        // Obtengo los formulario según el grupo del usuario
        public List<Formularios> ObtenerFormulariosPorGrupo(int grupo)
        {
            var Consulta = from oPerfil in oPerfiles.ToList()
                           where oPerfil.Grupo.id == grupo
                           group oPerfil by oPerfil.Formulario into Perfiles
                           select Perfiles.Key;
            return (List<Formularios>)Consulta.ToList();
        }

        // Obtengo los formularios según modulo al que pertenecen
        public List<Formularios> ObtenerFormulariosPorModulo(Modulos oModulo)
        {
            var Consulta = from oPerfil in oPerfiles.ToList()
                           where oPerfil.Formulario.Modulo == oModulo
                           group oPerfil by oPerfil.Formulario into Formularios
                           select Formularios.Key;
            return (List<Formularios>)Consulta.ToList();
        }

        // Obtengo los permisos según el grupo del usuario y el formulario seleccionado
        public List<Permisos> ObtenerPermisos(int grupo, string formulario)
        {
            var Consulta = from oPerfil in oPerfiles.ToList()
                           where oPerfil.Grupo.id == grupo && oPerfil.Formulario.descripcion == formulario
                           select oPerfil.Permiso;
            return (List<Permisos>)Consulta.ToList();
        }

        // Elimino un perfil
        public void BajaPerfil(Perfiles oPerfil)
        {
            oPerfiles.DeleteObject(oPerfil);
            oModelo_Entidades.SaveChanges();
        }

        //Agrego un perfil
        public void AltaPerfil(Perfiles oPerfil)
        {
            oPerfiles.AddObject(oPerfil);
            oModelo_Entidades.SaveChanges();
        }

        //Modifico a un perfil
        public void ModificarPerfil(Perfiles oPerfil)
        {
            oModelo_Entidades.ApplyCurrentValues("Perfiles", oPerfil);
            oModelo_Entidades.SaveChanges();
        }

        // Obtengo los perfiles
        public List<Perfiles> ObtenerPerfiles()
        {
            return oPerfiles.ToList();
        }

        // Valido que no exista un perfil dado el grupo, formulario y permiso
        public Boolean ValidarPerfil(Grupos oGrupo, Formularios oFormulario, Permisos oPermiso)
        {
            Perfiles oPerfil = oPerfiles.ToList().Find(delegate(Perfiles fPerfil)
            {
                return fPerfil.Grupo == oGrupo && fPerfil.Formulario == oFormulario && fPerfil.Permiso == oPermiso;
            });

            if (oPerfil == null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // Metodo de validación general para todos los perfiles
        public List<Perfiles> FiltrarPerfiles(string grupo, string formulario, string permiso)
        {
            var Consulta = from oPerfil in oPerfiles.ToList()
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

            return (List<Perfiles>)Consulta.ToList();
        }
    }
}
