using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
  public  class cCU_AltaTramite
    {

      //Declaro variables
      Modelo_Entidades.WASSTDEntidades oModelo_Entidades;
      private static cCU_AltaTramite instancia;

        public static cCU_AltaTramite ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cCU_AltaTramite();

            return instancia;
        }

        // Coloco al constructor como privado.
        private cCU_AltaTramite()
        {           
            oModelo_Entidades = Modelo_Entidades.WASSTDEntidades.ObtenerInstancia();
        }






        // Validar Obligatorios (PASO 4 CU ALTA TRAMITE)
        public bool ValidarObligatorios(Modelo_Entidades.Tramite oTramite)
        {
            List<string> msgError = new List<string>();

            //Valido DETALLE
            if (oTramite.Detalles_Tramite.Count == 0)
            {
                msgError.Add("Debe asignarle un Detalles a la descripción del tramite.");
            }
            
            //Valido PERSONA
            if (oTramite.Persona == null)
            {
                msgError.Add("Debe seleccionar una Persona a la cual le carga el trámite");
            }

            //Valido TIPO TRAMITE
            if (oTramite.Tipo_Tramite == null)
            {
                msgError.Add("Debe seleccionar un Tipo de Trámite.");
            }

            
           

           //VALIDAR TRAMITE EXISTENTE
           if (!ValidarTramiteExistente(oTramite))
           {
               string errorTramiteExistente = "Ya existe un trámite de " + oTramite.Tipo_Tramite.descripcion + " registrado para " + oTramite.Persona.nombre_apellido + ".";
               msgError.Add(errorTramiteExistente);
           }

           foreach (String error in msgError)
           {
               throw new Exception(error);
           }
            if(msgError.Count == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        // CU ALTA TRAMITE: REGISTRARLO EN EL SISTEMA (PASO 5)
        public void AltaTramite(Modelo_Entidades.Tramite oTramite)
        {
            oModelo_Entidades.AddToTramites(oTramite);
            oModelo_Entidades.SaveChanges();

        }


        //VALIDO SI EXISTE UN TRAMITE DEL TIPO INGRESADO PARA LA PERSONA SELECCIONADA. DEVUELVE TRUE SI LO ENCUENTRA
        private Boolean ValidarTramiteExistente(Modelo_Entidades.Tramite pTramite)
        {

            Modelo_Entidades.Tramite oTramite= oModelo_Entidades.Tramites.ToList().Find(delegate(Modelo_Entidades.Tramite fTramite)
            {
                return (fTramite.Persona.dni == pTramite.Persona.dni && fTramite.Tipo_Tramite.id == pTramite.Tipo_Tramite.id);
            });


            if (oTramite == null)
            {     //Si no se encontro tramite registrado con el dni ingresado y con el mismo tipo de tramite, devuelvo true
                return true;
            }

            else
            {     //Si ya existe un tramite de este tipo para esta persona, devuelvo false
                return false;
            }
 
        }
    }
}
