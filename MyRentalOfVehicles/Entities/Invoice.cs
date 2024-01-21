using System.Globalization;
namespace MyRentalOfVehicles.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basePayment, double tax)
        {
            BasicPayment = basePayment;
            Tax = tax;
        }

        //abaixo, vamos usar uma 'propriedade calculada', semelhante
        //a uma função, mas recebe os argumentos como um objeto
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return
                $"Base Payment:" +
                $"{BasicPayment.ToString("F2", CultureInfo.InvariantCulture)} \n"  +
                $"Tax: {Tax.ToString("F2", CultureInfo.InvariantCulture)} \n" +
                $"Total Payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";

        }

    }
}
