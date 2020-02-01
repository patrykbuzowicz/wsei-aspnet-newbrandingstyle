namespace NewBrandingStyle.Web.Services
{
    public class SingletonService
    {
        private readonly TransientService _transient;
        private int _value;

        public SingletonService(TransientService transient)
        {
            _transient = transient;
        }

        public string GetMessage()
        {
            _value++;
            return $"singleton value: {_value}";
        }
    }
}
