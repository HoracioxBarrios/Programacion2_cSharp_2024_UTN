namespace LibreriaClases
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor < min || valor > max)
            {
                return false;
            }
            return true;
        }

        /// <summary>Valida que sean iguales entre datoIngresado y el datoComparador
        /// </summary> 
        /// <param name="datoIngresado">Representa el dato ingresado a comparar e tipo string</param>
        /// <param name="datoComparador">Representa el dato comparador en tipo string</param>
        /// <returns>True si datoIngresado es igual a datoComparador sino false</returns>
        public static bool ValidarRespuesta(string datoIngresado, string datoComparador)
        {
            bool esValido = false;
            if (datoIngresado == datoComparador)
            {
                esValido = true;
            }
            return esValido;
        }
    }
}
