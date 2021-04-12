namespace Bridge
{
    class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {

        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with " +
                base._implementation.OperationImplementation();
        }
    }
}
