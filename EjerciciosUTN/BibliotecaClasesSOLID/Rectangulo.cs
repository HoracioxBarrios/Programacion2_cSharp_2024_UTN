namespace BibliotecaClasesS
{
    /// <summary>
    /// Clase que va a representar un rectángulo
    /// </summary>
    public class Rectangulo
    {
        public double Altura { get; set; }
        public double Ancho { get; set;}

        public Rectangulo(double altura, double ancho) 
        {
            this.Altura = altura;
            this.Ancho = ancho;
        }
    }
}
