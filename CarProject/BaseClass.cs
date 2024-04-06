namespace CarProject
{
    public class BaseClass
    {
        public int Id { get; set; }

        public BaseClass()
        {
            Id = IncrementId();
        }

        private static int id = 1;
        private int IncrementId()
        {
            return id++;
        }
    }
}
