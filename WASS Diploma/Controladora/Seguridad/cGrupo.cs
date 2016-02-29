using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Controladora
{
    public class cGrupo
    {
        // Declaración de variables a usar en la clase
        private static cGrupo instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;

        //Aplico el patron de diseño Singleton para la clase cGrupo (cuando la solicitan desde otra)
        public static cGrupo ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cGrupo();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cGrupo()
        {
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }

        // Obtengo los grupos
        public List<Grupos> ObtenerGrupos()
        {
            return oGruposs.ToList();
        }

        // Elimino a un grupo
        public void EliminarGrupo(Grupos oGrupo)
        {
            oModelo_Entidades.DeleteObject(oGrupo);
            oModelo_Entidades.SaveChanges();
        }

        // Agrego un grupo
        public void AgregarGrupo(Grupos oGrupo)
        {
            oModelo_Entidades.AddToGrupos(oGrupo);
            oModelo_Entidades.SaveChanges();
        }

        // Busco a un título por su ID y lo devuelvo
        public Grupos BuscarGrupoPorId(int id)
        {
            // Busca el grupo por la descripcion y lo devuelve.
            Grupos oGrupo = oGruposs.ToList().Find(delegate(Grupos fGrupo)
            {
                return fGrupo.id == id;
            });

            return oGrupo;
        }

        // Modifico un grupo
        public void ModificarGrupo(Grupos oGrupo)
        {
            oModelo_Entidades.ApplyCurrentValues("Grupos", oGrupo);
            oModelo_Entidades.SaveChanges();
        }

        // Busco los grupos por una descripción parcial
        public List<Grupos> FiltrarGrupos(string texto)
        {
            var Consulta = from oGrupo in oGruposs.ToList()
            where oGrupo.descripcion.Contains(texto)
            select oGrupo;
            return (List<Grupos>)Consulta.ToList();
        }

        // Busco los grupos dado un usuario
        public List<Grupos> BuscarGruposdelUsuario(Usuarios miUsuario)
        {
            var Consulta = from oGrupo in oGruposs.ToList()
                           where oGrupo.Usuarios.Contains(miUsuario)
                           select oGrupo;
            return (List<Grupos>)Consulta.ToList();
        }

        // Valido que no exista un grupo dado el nombre del grupo
        public Boolean ValidarGrupo(string grupo)
        {
            Grupos oGrupo = oGruposs.ToList().Find(delegate(Grupos fGrupo)
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

        // Valido que no un grupo no tengo miembros asociados
        public Boolean ValidarMiembrosGrupo(Grupos oGrup)
        {
            Grupos oGrupo = oGruposs.ToList().Find(delegate(Grupos fGrupo)
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
    }
}

