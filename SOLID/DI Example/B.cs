namespace SOLID.DI_Example
{
    public class B
    {
        private readonly IAInterface _iaInterface;
        public B(IAInterface aInterface)
        {
            _iaInterface = aInterface;
        }
        public B()
        {
            //tight coupling 
            //loose coupling
            //A a = new A();
            //_iaInterface.Test();
            //a.Test();

            //A a = new A();
        }
    }
}
