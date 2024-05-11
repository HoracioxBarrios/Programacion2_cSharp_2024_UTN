namespace LibreriaClasesIndexadores
{
    public class Consecionaria
    {
        private List<Coche> _cocheList;

        public Coche this[int id]
        {
            get
            {
                foreach (var coche in _cocheList)
                {
                    if (coche.Id == id)
                    {
                        return coche;
                    }
                }
                return null;
            }

        }


        public Consecionaria(Coche coche)
        {
            _cocheList = new List<Coche>();
            this._cocheList.Add(coche);
        }
    }
}
