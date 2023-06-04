
using Seção14_Interfaces.Entities;

namespace Seção14_Interfaces.Services
{
    class RentalService
    {
        public double PricePerhour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxServices _brazilTaxServices = new BrazilTaxServices();

        public RentalService(double pricePerhour, double pricePerDay)
        {
            PricePerhour = pricePerhour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerhour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxServices.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
