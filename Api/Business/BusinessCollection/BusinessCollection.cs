namespace Business.BusinessCollection
{
    public class BusinessCollection
    {
        private FacturaBusiness FacturaB;
        private PaqueteBusiness PaqueteB;
        public BusinessCollection()
        {
            this.FacturaB = new FacturaBusiness();
        }
        public FacturaBusiness getFacturaB()
        {
            return this.FacturaB;
        }
        public PaqueteBusiness getPaqueteB()
        {
            return this.PaqueteB;
        }


    }
}
