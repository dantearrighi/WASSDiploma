using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controladora
{
    public class cEncriptacion
    {
        private static cEncriptacion instancia;
        
        // Aplico el patrón de diseño Singleton a la clase
        public static cEncriptacion ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new cEncriptacion();

            return instancia;
        }



        // Coloco al constructor como privado.
        private cEncriptacion()
        {
            
        }


        public string Encriptar(string valor)
        {
            string clave;
            System.Security.Cryptography.SHA1CryptoServiceProvider provider = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(valor);
            byte[] inArray = provider.ComputeHash(bytes);
            provider.Clear();
            clave = Convert.ToBase64String(inArray);
            return clave;
        }
    }
}
