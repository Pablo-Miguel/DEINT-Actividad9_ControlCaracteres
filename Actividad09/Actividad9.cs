using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Actividad09
{
    public class Actividad9
    {
        static void Main(string[] args)
        {
        }

        public static bool cadenaContenedora(string cadena, string valor)
        {
            return Regex.IsMatch(cadena, valor);
        }

        public static bool numeroEntero(string v)
        {
            return Regex.IsMatch(v, @"^[0–9]+$");
            //return Regex.IsMatch(v, @"^\d+$");
        }

        public static bool isSpanish(string telefono)
        {
            //return Regex.IsMatch(telefono, @"^((\+0034) || (\+34))? ([0–9]{9}) || (-[0-9]{3}-[0-9]{2}-[0-9]{2}-[0-9]{2}) || ([0-9]{3}-[0-9]{2}-[0-9]{2}-[0-9]{2})$");
            return Regex.IsMatch(telefono, @"^\+?(00)?(34)?-?\d{3}-?\d{2}-?\d{2}-?\d{2}$");
        }

        public static bool isCorrectEmail(string email)
        {
            return Regex.IsMatch(email, @"^.+@.+\.\w+$");
        }

        public static bool numeroPositivo(string v)
        {
            return Regex.IsMatch(v, @"^\+?\d+([.,]\d+)?$");
        }

        public static bool isOctal(string v)
        {
            return Regex.IsMatch(v, @"^[0-8]+$");
        }

        public static bool dni(string v)
        {
            return Regex.IsMatch(v, @"^\w{8}[A-Z]$");
        }

        public static bool fechaFormat(string v)
        {
            return Regex.IsMatch(v, @"^\d{2}/\d{2}/\d{4}$");
        }

        public static bool isBinario(string v)
        {
            return Regex.IsMatch(v, @"^[01]+$");
        }
    }
}
