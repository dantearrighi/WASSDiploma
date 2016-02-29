using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
namespace Controladora.Seguridad
{
    public class cCU_GestionarPerfiles
    {
        // Declaración de variables a usar en la clase
        private static cCU_GestionarPerfiles instancia;
        private Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
        Controladora.cPerfil cPerfil;
        Controladora.cGrupo cGrupo;
        Controladora.cUsuario cUsuario; 


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
        }

        //CU RECUPERAR PERFIL POR FORMULARIO
        public List<String> RecuperarPerfilPorFormulario(Usuarios oUsuario, string form)
        {
            cPerfil = Controladora.cPerfil.ObtenerInstancia();
            cGrupo = Controladora.cGrupo.ObtenerInstancia();
            cUsuario = Controladora.cUsuario.ObtenerInstancia();

            List<String> AccionesHabilitadas = new List<String>();
            String accion;
          

            try
            {
                foreach (Grupos oGrupo in cUsuario.ObtenerGruposUsuario(oUsuario.id))
                {
                    foreach (Permisos oPermiso in cPerfil.ObtenerPermisos(oGrupo.id, form))
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


    }
}
