
using Seção14_Interfaces.Entities;

namespace Seção14_Interfaces.Services
{
    class RentalService
    {
        public double PricePerhour { get; private set; }
        public double PricePerDay { get; private set; }

        public RentalService(double pricePerhour, double pricePerDay)
        {
            PricePerhour = pricePerhour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {

        }
    }
}
