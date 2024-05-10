namespace BibliotecaClassPolimorfismo
{
    public abstract class Padre : IPadreMethods
    {
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public  abstract void Mostrar();
        public  abstract bool IsTrue(int n);


    }
}
