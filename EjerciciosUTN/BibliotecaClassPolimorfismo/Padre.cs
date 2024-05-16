namespace BibliotecaClassPolimorfismo
{
    public abstract class Padre : IMostrable
    {
        public string? Nombre { get; set; }
        public int Edad {  get; set; }




        //Los Metodos Abstract no tienen implementacion o comportamiento y debe ser implementado por las clases que heredan de ella.
        public abstract void Mostrar(); 


    }
}
