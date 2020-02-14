namespace NewBrandingStyle.Web.Services
{
    public class TransientService
    {
        private int _value;

        public string GetMessage()
        {
            _value++;
            return $"transient value: {_value}";
        }
    }
}
