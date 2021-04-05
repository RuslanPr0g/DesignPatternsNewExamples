using FactoryMethod.Transport;

namespace FactoryMethod.Logistic
{
    public class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
