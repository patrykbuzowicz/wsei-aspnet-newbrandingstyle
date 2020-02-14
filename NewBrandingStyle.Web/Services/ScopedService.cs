namespace NewBrandingStyle.Web.Services
{
    public class ScopedService
    {
        private int _value;

        public string GetMessage()
        {
            _value++;
            return $"scoped value: {_value}";
        }
    }
}
