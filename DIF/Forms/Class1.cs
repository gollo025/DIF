using System;
using System.Text.RegularExpressions;

namespace DIF.Forms
{
    public static class InputValidator
    {
        // Método para validar si una cadena contiene solo números
        public static bool EsSoloNumeros(string texto)
        {
            return Regex.IsMatch(texto, @"^\d+$");
        }

        // Método para validar si una cadena contiene solo letras (sin números ni caracteres especiales)
        public static bool EsSoloLetras(string texto)
        {
            return Regex.IsMatch(texto, @"^[A-Za-zÁÉÍÓÚÑáéíóúñ]+$");
        }

        // Método para validar el formato del RFC en México
        public static bool EsRFCValido(string rfc)
        {
            if (string.IsNullOrWhiteSpace(rfc))
                return false;

            // Convertir a mayúsculas
            rfc = rfc.ToUpper();

            // Expresión regular para el formato del RFC
            string patronRFC = @"^[A-ZÑ&]{4}\d{6}[A-Z\d]{2,3}$";

            // Validar con la expresión regular
            return Regex.IsMatch(rfc, patronRFC);
        }
    }
}
