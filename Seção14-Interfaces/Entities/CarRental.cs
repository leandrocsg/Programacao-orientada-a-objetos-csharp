
namespace Seção14_Interfaces.Entities
{
    class CarRental
    {

        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; private set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null; //Não há necessidade de colocar, pois automaticamente o objeto associado recebe nulo
        }
    }

}
